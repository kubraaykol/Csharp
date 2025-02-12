using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.UI.Entities.Abstractions
{
    public abstract class Entity
    {
        //abstract: Entity sınıfı newlenemez. Bu sınıftan yeni bir Entity nesnesi türetilsin istemiyoruz.
        public Entity() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }  
        public DateTime CreatedDate { get; set; }
    }
}
