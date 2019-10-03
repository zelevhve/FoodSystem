using System;
using System.Collections.Generic;
using System.Linq;
using FoodSystem.Contracts;
using FoodSystem.Model;

namespace FoodSystem.DataContext
{
    public class UsuarioData : Contracts.IUsuarioData
    {
        public void Delete(Usuario entity)
        {
            using (UsuarioContext db = new UsuarioContext())
            {

                var t = db.Usuario.First(p => p.UsuarioId == entity.UsuarioId);
                db.Usuario.Remove(t);
                db.SaveChanges();
            }
        }
        public Usuario GetById(int id)
        {
            using (UsuarioContext db = new UsuarioContext())
            {
                var t = db.Usuario.Where(p => p.UsuarioId == id).FirstOrDefault();
                return t;
            }
        }

        public Usuario Save(Usuario entity)
        {
            using (UsuarioContext db = new UsuarioContext())
            {
                if (entity.UsuarioId == 0)
                {
                    var t = db.Usuario.Add(entity);
                    db.SaveChanges();
                    return t;
                }
                else
                {

                    var tUpdate = db.Usuario.Where(p => p.UsuarioId == entity.UsuarioId).FirstOrDefault();
                    tUpdate = entity;
                    db.SaveChanges();
                    return tUpdate;
                }

            }
        }

        IList<Usuario> IDataBase<Usuario>.GetAll()
        {
            using (UsuarioContext db = new UsuarioContext())
            {
                return db.Usuario.ToList();
            }
        }
    }
}
