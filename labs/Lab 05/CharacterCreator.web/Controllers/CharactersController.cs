using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharacterCreator.web.Models;

namespace CharacterCreator.web.Controllers
{
    public class CharactersController : Controller
    {
        static Roster s_characters = new Roster();
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
        public ActionResult Add ( CharacterModel model )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var character = s_characters.Add(model.Convert());
                    return RedirectToAction(nameof(CharacterSheet), new { id = character.Id });
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
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



    }
}