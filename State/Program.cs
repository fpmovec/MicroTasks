using State.DB;
using State.States;

DBConnection sqlConnection = new DBConnection(new OpenState());
sqlConnection.Open();
sqlConnection.Process();
sqlConnection.Close();
sqlConnection.Open();
sqlConnection.Close();
