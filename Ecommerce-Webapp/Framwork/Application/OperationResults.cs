namespace ECS.Framework.Application
{
    public class OperationResults
    {
        public bool IsSuccedded { get; set; }
        public string Message { get; set; }

        public OperationResults()
        {
            IsSuccedded = false;
        }

        public OperationResults Succedded(string message = "عملیات با موفقیت انجام گردید") 
        {
            IsSuccedded = true;
            Message = message;
            return this;
        }

        public OperationResults Failed(string message)
        {
            IsSuccedded = false;
            Message = message;
            return this;
        }
    }
}
