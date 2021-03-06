using Common;
using System.Collections.Generic;
using DbOpertion.Operation;
using DbOpertion.Models;

namespace DbOpertion.Function
{
    public partial class ProducerconectinfoFunc : SingleTon<ProducerconectinfoFunc>
    {
        /// <summary>
        /// 根据主键删除数据
        /// </summary>
        /// <param name="KeyId">主键Id</param>
        /// <returns>是否成功</returns>
        public bool DeleteById(int KeyId)
        {
            return ProducerconectinfoOper.Instance.DeleteById(KeyId);
        }

        /// <summary>
        /// 根据模型删除数据
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public bool DeleteModel(Producerconectinfo model)
        {
            return ProducerconectinfoOper.Instance.DeleteModel(model);
        }
        /// <summary>
        /// 根据模型更新
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public bool Update(Producerconectinfo model)
        {
            return ProducerconectinfoOper.Instance.Update(model);
        }
        /// <summary>
        /// 根据模型插入
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public bool Insert(Producerconectinfo model)
        {
            return ProducerconectinfoOper.Instance.Insert(model);
        }
        /// <summary>
        /// 根据模型插入
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public int InsertReturnKey(Producerconectinfo model)
        {
            return ProducerconectinfoOper.Instance.InsertReturnKey(model);
        }
        /// <summary>
        /// 筛选全部数据
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns>对象列表</returns>
        public List<Producerconectinfo> SelectByModel(Producerconectinfo model)
        {
            return ProducerconectinfoOper.Instance.SelectAll(model);
        }
        /// <summary>
        /// 数据条数
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns>对象列表</returns>
        public int SelectCount(Producerconectinfo model)
        {
            return ProducerconectinfoOper.Instance.SelectCount(model);
        }

        /// <summary>
        /// 根据主键筛选数据
        /// </summary>
        /// <param name="KeyId">主键Id</param>
        /// <returns>是否成功</returns>
        public Producerconectinfo SelectById(int KeyId)
        {
            return ProducerconectinfoOper.Instance.SelectById(KeyId);
        }

        /// <summary>
        /// 根据主键筛选数据
        /// </summary>
        /// <param name="KeyId">主键Id</param>
        /// <returns>是否成功</returns>
        public List<Producerconectinfo> SelectByKeys(string Key, List<string> KeyId)
        {
            return ProducerconectinfoOper.Instance.SelectByKeys(Key,KeyId);
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
        public List<Producerconectinfo> SelectByPage(string Key, int start, int PageSize, bool desc, Producerconectinfo model, string SelectFiled)
        {
            return ProducerconectinfoOper.Instance.SelectByPage(Key, start, PageSize, desc, model);
        }    }
}
