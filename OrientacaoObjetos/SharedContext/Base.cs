using System;
using OrientacaoObjetos.NotificationContext;

namespace OrientacaoObjetos.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}