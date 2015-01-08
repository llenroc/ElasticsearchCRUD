﻿using ElasticsearchCRUD.Utils;

namespace ElasticsearchCRUD.Model.SearchModel
{
	public class Search
	{
		private IQueryContainer _query;
		private bool _querySet;
		private IFilterContainer _filter;
		private bool _filterSet;

		public IQueryContainer Query
		{
			get { return _query; }
			set
			{
				_query = value;
				_querySet = true;
			}
		}

		public IFilterContainer Filter
		{
			get { return _filter; }
			set
			{
				_filter = value;
				_filterSet = true;
			}
		}

		public void WriteJson(ElasticsearchCrudJsonWriter elasticsearchCrudJsonWriter)
		{
			elasticsearchCrudJsonWriter.JsonWriter.WriteStartObject();

			// TODO add properties 
			JsonHelper.WriteValue("query", _query, elasticsearchCrudJsonWriter, _querySet);
			JsonHelper.WriteValue("filter", _filter, elasticsearchCrudJsonWriter, _filterSet);
			elasticsearchCrudJsonWriter.JsonWriter.WriteEndObject();
		}

		public override string ToString()
		{
			var elasticsearchCrudJsonWriter = new ElasticsearchCrudJsonWriter();
			WriteJson(elasticsearchCrudJsonWriter);
			return elasticsearchCrudJsonWriter.GetJsonString();
		}
	}
}
