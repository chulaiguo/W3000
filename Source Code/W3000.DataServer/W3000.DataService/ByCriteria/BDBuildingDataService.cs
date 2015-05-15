using System.Collections.Generic;
using System.Text;
using Cheke;
using System.Data.SqlClient;
using System.Data;
using W3000.Data;
using W3000.Schema;

namespace W3000.DataService
{
	public partial class BDBuildingDataService
	{
        public BDBuildingDataCollection GetByCriteria(CriteriaBDBuildingView criteria)
        {
            int pageIndex = this.SecurityToken.BlockIndex;
            int pageSize = this.SecurityToken.BlockSize;
           
            return this.GetByCriteria(criteria, pageIndex, pageSize);
        }

        public BDBuildingDataCollection GetByCriteria(CriteriaBDBuildingView criteria, int pageIndex, int pageSize)
        {
            if (!UsrAccountDBRuleDataService.CanViewTable(base.SecurityToken, BDBuildingSchema.TableName, this.ConnectionString))
                return new BDBuildingDataCollection();

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
                this.GetOrderBySql(), this._dal.SQLColumns, BDBuildingSchema.TableName, BDBuildingSchema.TableAlias,
                this._dal.SQLLeftJoins, sqlWhere);
            builder.Append(") T ");
            builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);
            BDBuildingDataCollection list = this._dal.GetCollectionExBy(builder.ToString(), paraList.ToArray());

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

        public int GetCountByCriteria(CriteriaBDBuildingView criteria)
        {
            List<SqlParameter> paraList = new List<SqlParameter>();
            string sqlWhere = this.GetWhereSql(criteria, paraList);
            return this.GetCountBySqlWhere(sqlWhere, paraList);
        }

        private int GetCountBySqlWhere(string sqlWhere, List<SqlParameter> paraList)
        {
            string sql = string.Format("SELECT COUNT(*) FROM [{0}] as {1} {2} {3}",
               BDBuildingSchema.TableName, BDBuildingSchema.TableAlias,
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
                builder.AppendFormat("[{0}].[{1}] ASC", BDBuildingSchema.TableAlias, BDBuildingSchema.Address1);
            }

            return builder.ToString();
        }

        private string GetWhereSql(CriteriaBDBuildingView criteria, List<SqlParameter> paraList)
        {
            List<string> sqlList = new List<string>();

            //StreetNumber
            if (!string.IsNullOrEmpty(criteria.StreetNumber))
            {
                string sql = string.Format("[{0}].[{1}] LIKE @{2}",
                    BDBuildingSchema.TableAlias, BDBuildingSchema.StreetNumb, "StreetNumber");
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", "StreetNumber"), SqlDbType.VarChar);
                para.Value = string.Format("{0}%", criteria.StreetNumber);
                paraList.Add(para);
            }

            //StreetName
            if (!string.IsNullOrEmpty(criteria.StreetName))
            {
                string sql = string.Format("[{0}].[{1}] LIKE @{2}",
                    BDBuildingSchema.TableAlias, BDBuildingSchema.StreetName, "StreetName");
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", "StreetName"), SqlDbType.VarChar);
                para.Value = string.Format("{0}%", criteria.StreetName);
                paraList.Add(para);
            }

            //BuildingName
            if (!string.IsNullOrEmpty(criteria.BuildingName))
            {
                string sql = string.Format("[{0}].[{1}] LIKE @{1}",
                   BDBuildingSchema.TableAlias, BDBuildingSchema.BuildingName);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", BDBuildingSchema.BuildingName), SqlDbType.VarChar);
                para.Value = string.Format("{0}%", criteria.BuildingName);
                paraList.Add(para);
            }

            //State
            if (!string.IsNullOrEmpty(criteria.State))
            {
                string sql = string.Format("[{0}].[{1}] = @{1}",
                   BDBuildingSchema.TableAlias, BDBuildingSchema.State);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", BDBuildingSchema.State), SqlDbType.VarChar);
                para.Value = criteria.State;
                paraList.Add(para);
            }

            //City
            if (!string.IsNullOrEmpty(criteria.City))
            {
                string sql = string.Format("[{0}].[{1}] LIKE @{1}",
                   BDBuildingSchema.TableAlias, BDBuildingSchema.City);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", BDBuildingSchema.City), SqlDbType.VarChar);
                para.Value = string.Format("{0}%", criteria.City);
                paraList.Add(para);
            }

            //Zipcode
            if (!string.IsNullOrEmpty(criteria.Zipcode))
            {
                string sql = string.Format("[{0}].[{1}] LIKE @{1}",
                   BDBuildingSchema.TableAlias, BDBuildingSchema.Zipcode);
                sqlList.Add(sql);

                SqlParameter para = new SqlParameter(string.Format("@{0}", BDBuildingSchema.Zipcode), SqlDbType.VarChar);
                para.Value = string.Format("{0}%", criteria.Zipcode);
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
