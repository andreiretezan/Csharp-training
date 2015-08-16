using Masini.Library.Entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library
{
    /// <summary>
    /// DataManager va fi responsabila cu a mentine "starea" = colectia de masini pe care se lucreaza; 
    /// 
    /// * pentru inceput vom tine colectia in memorie, urmand ca mai apoi sa implementam alte 2 metode de persistenta: 
    /// a) intr-un fisier cu date serializate intr-un format specific (JSON)
    /// b) intr-o baza de date
    /// 
    /// * este foarte important sa ne asiguram ca la orice moment din timpul executiei exista DOAR o singura instanta din aceasta clasa !!! 
    /// 
    /// @todo: asigura-te ca nu se vor putea crea mai multe instante din aceasta clasa -> citeste si implementeaza patternul Singleton 
    /// 
    /// @todo: studiaza te rog asta: http://www.c-sharpcorner.com/UploadFile/0f68f2/using-lambda-expression-over-a-list-in-C-Sharp/ si foloseste 
    /// aceeasi tehnica unde e nevoie; in metodele de mai jos; alternativ poti folosi si structuri repetitive : for/foreach/do until
    /// </summary>

    public class DataManager
    {
        private List<Masina> _all;

        //@todo: implementeaza constructor; tine cont de ce am scris in descrierea clasei

        public List<Masina> Toate()
        {
            //@todo: implementeaza 
            throw new NotImplementedException();
        }

        public List<Masina> ToateDinCategoria(Categorie categoria)
        {
            //@todo: implementeaza
            throw new NotImplementedException();
        }

        public List<Masina> ToateCuAerConditionat()
        {
            //@todo: implementeaza
            throw new NotImplementedException();
        }

        public void AdaugaMasina(Masina masina)
        {
            //@todo: implementeaza add
            throw new NotImplementedException();
        }

        public void EditeazaMasina(Masina masina)
        {
            //@todo: implementeaza edit: gaseste si editeaza; cauta dupa ID
            throw new NotImplementedException();
        }

        public void StergeMasina(Guid id)
        {
            //@todo: implementeaza delete: gaseste si sterge; cauta dupa ID
            throw new NotImplementedException();
        }
    }
}
