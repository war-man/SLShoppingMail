using Common;
using System.Collections.Generic;
using DbOpertion.Operation;
using DbOpertion.Models;

namespace DbOpertion.Function
{
    public partial class TodaysuccessorderFunc : SingleTon<TodaysuccessorderFunc>
    {
        /// <summary>
        /// 筛选全部数据
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns>对象列表</returns>
        public List<Todaysuccessorder> SelectByModel(Todaysuccessorder model)
        {
            return TodaysuccessorderOper.Instance.SelectAll(model);
        }
        /// <summary>
        /// 数据条数
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns>对象列表</returns>
        public int SelectCount(Todaysuccessorder model)
        {
            return TodaysuccessorderOper.Instance.SelectCount(model);
        }

        /// <summary>
        /// 根据主键筛选数据
        /// </summary>
        /// <param name="KeyId">主键Id</param>
        /// <returns>是否成功</returns>
        public Todaysuccessorder SelectById(int KeyId)
        {
            return TodaysuccessorderOper.Instance.SelectById(KeyId);
        }

        /// <summary>
        /// 根据主键筛选数据
        /// </summary>
        /// <param name="KeyId">主键Id</param>
        /// <returns>是否成功</returns>
        public List<Todaysuccessorder> SelectByKeys(string Key, List<string> KeyId)
        {
            return TodaysuccessorderOper.Instance.SelectByKeys(Key,KeyId);
        }
        /// <summary>
        /// 根据分页筛选数据
        /// </summary>
        /// <param name="Key">主键</param>
        /// <param name="start">开始数据</param>
        /// <param name="PageSize">页面长度</param>
        /// <param name="desc">排序</param>
        /// <param name="model">对象</param>
        /// <returns>对象列表</returns>
        public List<Todaysuccessorder> SelectByPage(string Key, int start, int PageSize, bool desc, Todaysuccessorder model, string SelectFiled)
        {
            return TodaysuccessorderOper.Instance.SelectByPage(Key, start, PageSize, desc, model);
        }    }
}
