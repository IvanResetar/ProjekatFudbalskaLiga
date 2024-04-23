using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.DrzavaSO
{
    public class ZapamtiDrzavuSO : SystemOperationsBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Drzava drzava = (Drzava)entity;
            drzava.DrzavaID = repository.VratiID(drzava);
            Result = repository.Sacuvaj(drzava);
        }
    }
}
