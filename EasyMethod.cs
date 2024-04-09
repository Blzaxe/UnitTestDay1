namespace UnitTestDay1
{
    public class EasyMethod
    {
        //private int BaseNumber = 5;
        private int BaseNumber = 2; //因應業務需求，基數需要改變成2

        /// <summary>
        /// 原始Method1
        /// </summary>
        /// <returns>回傳是7</returns>
        /// <remark>原先邏輯是基數加上2</remark>
        public int Method1()
        {
            //return BaseNumber + 2;
            return BaseNumber + 5;
        }

        /// <summary>
        /// 後來增加Method2後
        /// 呼叫它時能回傳給我10，而且因應業務需求，基數需要改變成2
        /// </summary>
        /// <returns></returns>
        public int Method2()
        {
            return BaseNumber + 8;
        }
    }
}