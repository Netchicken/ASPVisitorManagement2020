using System.Collections.Generic;

namespace ASPVisitorManagement2020.Business
{
    public interface ITextFileOperations
    {
        IEnumerable<string> LoadConditionsForAcceptanceText();
    }
}