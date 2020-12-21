﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateItemsInItemsControl.Data
{
    public class Representantives : ObservableCollection<ServiceRep>
    {
        public Representantives()
        {
            Add(new ServiceRep("Haluk Kocak", Region.Africa));
            Add(new ServiceRep("Reed Koch", Region.Antartica));
            Add(new ServiceRep("Christine Koch", Region.Asia));
            Add(new ServiceRep("Alisa Lawyer", Region.Australia));
            Add(new ServiceRep("Petr Lazecky", Region.Europe));
            Add(new ServiceRep("Karina Leal", Region.NorthAmerica));
            Add(new ServiceRep("Kelley LeBeau", Region.SouthAmerica));
            Add(new ServiceRep("Yoichiro Okada", Region.Africa));
            Add(new ServiceRep("Tülin Oktay", Region.Antartica));
            Add(new ServiceRep("Preeda Ola", Region.Asia));
            Add(new ServiceRep("Carole Poland", Region.Australia));
            Add(new ServiceRep("Idan Plonsky", Region.Europe));
            Add(new ServiceRep("Josh Pollock", Region.NorthAmerica));
            Add(new ServiceRep("Daphna Porath", Region.SouthAmerica));
        }
    }
}
