using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Library.Entities
{
    public class Book
    {
        #region Attributs
        private int id;
        private string authors;
        private string title;
        private string publisher;
        private string myVar;

        public string MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }



        #endregion
        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Authors
        {
            get { return authors; }
            set { authors = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        #endregion
        #region Constructor
        #endregion
        #region Functions
        #endregion
    }
}
