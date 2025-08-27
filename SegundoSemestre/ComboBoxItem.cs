using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre
{
    // Esta classe serve como um modelo para os itens que vamos adicionar
    // aos nossos ComboBoxes. Ela guarda tanto o texto a ser exibido
    // quanto o valor (ID) que fica "escondido".
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        // O método ToString() é chamado pelo ComboBox para decidir
        // qual texto ele deve exibir na lista.
        public override string ToString()
        {
            return Text;
        }


    }
}

