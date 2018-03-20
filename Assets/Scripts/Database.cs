using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Mono.Data.Sqlite;
using System.Data;
using System;

public class Database : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string conn = "URI=file:" + Application.dataPath + "/Plugins/UserInfo.s3db"; //Path to database
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); // Open Conmnection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT * " + "FROM USERINFO"; // Table name
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string username = reader.GetString(1);
            string password = reader.GetString(2);

            Debug.Log("ID = " + id + " username = " + username + " password = " + password);
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
