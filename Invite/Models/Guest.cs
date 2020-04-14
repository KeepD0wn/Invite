using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Invite.Models
{
    public class Guest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Пожалуйства введите своё имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйства введите email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите, примите ли участие в вечеринке")]
        public bool? WillAttend { get; set; }

        public void InsertCustomer()
        {
            // Создать объект для записи в БД
            Guest guest = new Guest
            {
                Name = this.Name,
                Email = this.Email,
                Phone = this.Phone,
                WillAttend = this.WillAttend
            };

            // Создать объект контекста
            InviteContext context = new InviteContext();

            // Вставить объект в БД и сохранить изменения
            context.Guests.Add(guest);
            context.SaveChanges();
        }
    }
}