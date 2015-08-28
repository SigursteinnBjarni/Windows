using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace powershelltest
{
    [Cmdlet(VerbsCommon.Get, "Salutation")]
    public class Class1 : PSCmdlet
    {
        private string nameCollection;
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Position = 0
        )]

        [Alias("Person", "Firstname")]
        public string name
        {
            get{return nameCollection;}
            set{nameCollection = value;}
        }
        //Start override functions
        protected override void BeginProcessing()
        {
 	         base.BeginProcessing();
        }
        protected override void ProcessRecord()
        {
            string output = "";
            for (int i = 0; i < nameCollection.Length; i++)
            {
                if (i % 2 == 0)
                {
                    output += char.ToUpper(nameCollection[i]);
                }
                else 
                {
                    output += nameCollection[i];
                }
            }
            WriteObject(output);
        }
        protected override void EndProcessing()
        {
 	         base.EndProcessing();
        }
        // End override functions
    }
}
