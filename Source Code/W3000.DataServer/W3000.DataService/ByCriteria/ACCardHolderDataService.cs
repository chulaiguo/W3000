using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Cheke;
using System.Data;
using W3000.Data;
using W3000.Schema;

namespace W3000.DataService
{
	public partial class ACCardHolderDataService
	{
        public ACCardHolderDataCollection GetByCriteria(CriteriaACCardHolderView criteria)
        {
            int pageIndex = this.SecurityToken.BlockIndex;
            int pageSize = this.SecurityToken.BlockSize;
            
            return this.GetByCriteria(criteria, pageIndex, pageSize);
        }

        public ACCardHolderDataCollection GetByCriteria(CriteriaACCardHolderView criteria, int pageIndex, int pageSize)
        {
            if (!UsrAccountDBRuleDataService.CanViewTable(base.SecurityToken, ACCardHolderSchema.TableName, this.ConnectionString))
                return new ACCardHolderDataCollection();

            if (pageIndex == -1)
            {
                pageIndex = 0;
                pageSize = 100000;
            }

            List<SqlParameter> paraList = new List<SqlParameter>();
            string sqlWhere = this.GetWhereSql(criteria, paraList);

            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT * FROM ( ");
            builder.AppendFormat("SELECT ROW_NUMBER() OVER({0}) as rowid, {1} FROM [{2}] as [{3}] {4} {5} ",
               this.GetOrderBySql(), this._dal.SQLColumns, ACCardHolderSchema.TableName, ACCardHolderSchema.TableAlias,
               this._dal.SQLLeftJoins, sqlWhere);
            builder.Append(") T ");
            builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);
            ACCardHolderDataCollection list = this._dal.GetCollectionExBy(builder.ToString(), paraList.ToArray());

            if (pageIndex == 0)
            {
                int count = this.GetCountBySqlWhere(sqlWhere, paraList);
                list.Block.Index = pageIndex;
                list.Block.Size = pageSize;

                if (list.Count < pageSize)
                {
                    list.Block.Count = 1;
                    list.Block.Records = list.Count;
                }
                else
                {
                    list.Block.Records = count;

                    int pageCount = (count / pageSize) + (count % pageSize == 0 ? 0 : 1);
                    list.Block.Count = pageCount;
                }
            }

            return list;
        }

        public int GetCountByCriteria(CriteriaACCardHolderView criteria)
        {
            List<SqlParameter> paraList = new List<SqlParameter>();
            string sqlWhere = this.GetWhereSql(criteria, paraList);
            return this.GetCountBySqlWhere(sqlWhere, paraList);
        }

        private int GetCountBySqlWhere(string sqlWhere, List<SqlParameter> paraList)
        {
            string sql = string.Format("SELECT COUNT(*) FROM [{0}] as {1} {2} {3}",
                ACCardHolderSchema.TableName, ACCardHolderSchema.TableAlias,
                this._dal.SQLLeftJoins, sqlWhere);

            object obj = this._dal.ExecuteScalar(sql, paraList.ToArray());
            if (obj == null)
                return 0;

            int count;
            if (!int.TryParse(obj.ToString(), out count))
            {
                return 0;
            }

            return count;
        }

        private string GetOrderBySql()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ORDER BY ");
            SortFieldCollection list = this.SecurityToken.GetSortFields();
            if (list.Count > 0)
            {
                int index = list.Count;
                foreach (SortField item in list)
                {
                    index--;

                    if (index <= 0)
                    {
                        builder.AppendFormat("{0} {1}", item.FieldAlias, item.ASC ? "ASC" : "DESC");
                    }
                    else
                    {
                        builder.AppendFormat("{0} {1}, ", item.FieldAlias, item.ASC ? "ASC" : "DESC");
                    }
                }
            }
            else
            {
                builder.AppendFormat("[{0}].[{1}], [{0}].[{2}] ASC", ACCardHolderSchema.TableAlias, ACCardHolderSchema.Sitecode, ACCardHolderSchema.Embossed);
            }

            return builder.ToString();
        }

        private string GetWhereSql(CriteriaACCardHolderView criteria, List<SqlParameter> paraList)
        {
            List<string> sqlList = new List<string>();

            //BDBuildingPK
            if (criteria.BDBuildingPK != Guid.Empty)
            {
                string sql = string.Format("[{0}].[{1}] = @{1}",
                    BDTenantSchema.TableAlias, BDTenantSchema.BDBuildingPK);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", BDTenantSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
                para.Value = criteria.BDBuildingPK;
                paraList.Add(para);
            }

            //BDTenantPK
            if (criteria.BDTenantPK != Guid.Empty)
            {
                string sql = string.Format("[{0}].[{1}] = @{1}",
                    ACCardHolderSchema.TableAlias, ACCardHolderSchema.BDTenantPK);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.BDTenantPK), SqlDbType.UniqueIdentifier);
                para.Value = criteria.BDTenantPK;
                paraList.Add(para);
            }

            //Tenant
            if (!string.IsNullOrEmpty(criteria.Tenant))
            {
                string sql = string.Format("[{0}].[{1}] LIKE @{1}",
                   BDTenantSchema.TableAlias, BDTenantSchema.Tenant);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", BDTenantSchema.Tenant), SqlDbType.VarChar);
                para.Value = string.Format("{0}%", criteria.Tenant);
                paraList.Add(para);
            }

            //FirstName
            if (!string.IsNullOrEmpty(criteria.FirstName))
            {
                string sql = string.Format("[{0}].[{1}] LIKE @{1}",
                    ACCardHolderSchema.TableAlias, ACCardHolderSchema.FirstName);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.FirstName), SqlDbType.VarChar);
                para.Value = string.Format("{0}%", criteria.FirstName);
                paraList.Add(para);
            }

            //LastName
            if (!string.IsNullOrEmpty(criteria.LastName))
            {
                string sql = string.Format("[{0}].[{1}] LIKE @{1}",
                    ACCardHolderSchema.TableAlias, ACCardHolderSchema.LastName);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.LastName), SqlDbType.VarChar);
                para.Value = string.Format("{0}%", criteria.LastName);
                paraList.Add(para);
            }

            //Sitecode
            if (criteria.Sitecode > 0)
            {
                string sql = string.Format("[{0}].[{1}] = @{1}",
                    ACCardHolderSchema.TableAlias, ACCardHolderSchema.Sitecode);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.Sitecode), SqlDbType.Int);
                para.Value = criteria.Sitecode;
                paraList.Add(para);
            }

            //Embossed
            if (criteria.Embossed > 0)
            {
                string sql = string.Format("[{0}].[{1}] = @{1}",
                    ACCardHolderSchema.TableAlias, ACCardHolderSchema.Embossed);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.Embossed), SqlDbType.Int);
                para.Value = criteria.Embossed;
                paraList.Add(para);
            }


            //Encoded
            if (criteria.Encoded > 0)
            {
                string sql = string.Format("[{0}].[{1}] = @{1}",
                    ACCardHolderSchema.TableAlias, ACCardHolderSchema.Encoded);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.Encoded), SqlDbType.Int);
                para.Value = criteria.Encoded;
                paraList.Add(para);
            }

            string sqlFilter = this.GetFilterBySql();
            if (sqlList.Count > 0)
            {
                StringBuilder sqlBuilder = new StringBuilder();
                sqlBuilder.Append(" WHERE ");
                for (int i = 0; i < sqlList.Count; i++)
                {
                    if (i == sqlList.Count - 1)
                    {
                        sqlBuilder.AppendFormat("{0}", sqlList[i]);
                    }
                    else
                    {
                        sqlBuilder.AppendFormat("{0} AND ", sqlList[i]);
                    }
                }

                if (!string.IsNullOrEmpty(sqlFilter))
                {
                    return string.Format("{0} AND {1} ", sqlBuilder, sqlFilter);
                }

                return sqlBuilder.ToString();
            }

            if (!string.IsNullOrEmpty(sqlFilter))
            {
                return string.Format(" WHERE {0}", this.GetFilterBySql());
            }

            return string.Empty;
        }

	    private string GetFilterBySql()
	    {
	        return string.Empty;
	    }
	}
}
