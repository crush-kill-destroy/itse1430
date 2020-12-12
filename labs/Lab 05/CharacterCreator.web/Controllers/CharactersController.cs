/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 05
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharacterCreator.web.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;

namespace CharacterCreator.web.Controllers
{
    public class CharactersController : Controller
    {
        static private Roster s_characters = new Roster();
        public ActionResult Index()
        {
            var characters = s_characters.GetAll()
                                         .Select(x => new CharacterModel(x))
                                         .OrderBy(x => x.Name);

            return View(characters);
        }

        public ActionResult CharacterSheet(int id)
        {
            var character = s_characters.Get(id);
            if (character == null)
                return HttpNotFound();

            return View(new CharacterModel(character));
        }

        public ActionResult Add ( )
        {
            return View(new CharacterModel());
        }

        [HttpPost]
        public ActionResult Add ( CharacterModel character )
        {
            character.uniqueName = NameCheck(character.Name);
            ObjectValidator.TryValidateFullObject(character).ForEach(x => ModelState.AddModelError("", x.ErrorMessage));

            if (ModelState.IsValid)
            {
                try
                {
                    character.Id = s_characters.Add(character.Convert()).Id;
                    return RedirectToAction(nameof(CharacterSheet), new { id = character.Id });
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(character);
        }

        
        public ActionResult Edit(int id)
        {
            var character = s_characters.Get(id);
            if (character == null)
                return HttpNotFound();

            return View(new CharacterModel(character));
        }

        [HttpPost]
        public ActionResult Edit ( CharacterModel character )
        {
            character.uniqueName = IdNameCheck(character);
            ObjectValidator.TryValidateFullObject(character).ForEach(x => ModelState.AddModelError("", x.ErrorMessage));

            if (ModelState.IsValid)
            {
                try
                {
                    s_characters.Update(character.Id, character.Convert());
                    return RedirectToAction(nameof(CharacterSheet), new { id = character.Id});
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var character = s_characters.Get(id);
            if (character == null)
                return HttpNotFound();

            return View(new CharacterModel(character));
        }

        [HttpPost]
        public ActionResult Delete ( CharacterModel character )
        {
            try
            {
                s_characters.Delete(character.Id);
                return RedirectToAction(nameof(Index));
            } catch (Exception e)
            {
                ModelState.AddModelError("", e);   
            }

            return View(character);
        }

        private bool NameCheck ( string name)
        {
            foreach(var check in s_characters.GetAll().Select( x => x.Name))
                if (name == check)
                    return false;
            return true;
        }

    private bool IdNameCheck ( CharacterModel character )
        {
            var characters = s_characters.GetAll();
            if (characters.Any())
                foreach (var test in characters)
                    if (character.Name == test.Name && test.Id != character.Id)
                        return false;
            return true;
        }

    }
}