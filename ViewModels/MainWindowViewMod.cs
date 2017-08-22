Oper1,Oper2
Syn
IsSynOrNum


private void Oper(object obj)
{
    if(Oper1 == null ) Oper1 = Result;
    else Oper2 = Result;
    
    syn = ((Button)obj).Content.ToString();
    oper = OperationFactory.createOperation(syn);
    if(syn == "√")
    {
        
    }
}


        private void Num(object obj)
        {
            if (this.Result.EndsWith(".") && ((Button)obj).Content.ToString()==".")  return; //连续"."的处理
            
            this.Result = "";
            string num = ((Button)obj).Content.ToString(); 
            this.Result = Result +num;
            this.Formula = this.Formula + num;
            
            IsSynOrNum = 0;
        }
