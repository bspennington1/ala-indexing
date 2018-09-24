OpenFileDialog ofd = new OpenFileDialog();
ofd.Filter = "conference.csv | conference.csv";
ofd.ShowDialog();
if (ofd.FileName.Equals(String.Empty)) return;
if (!File.Exists(ofd.FileName)) return;
StreamReader sr = new StreamReader(ofd.FileName);
sr.ReadLine();
while (!sr.EndOfStream)
{
    data.Add(ReadRow(sr));
}
sr.Close();
foreach (List<string> l in data)
{
    SqlCommand sc = new SqlCommand("insert into Conference (ConferenceCode,Name,Subdivision) VALUES (@ConferenceCode,@Name,@Subdivision)", SqlStuff.theConnection);
    sc.Parameters.Add(new SqlParameter("@ConferenceCode", l[0]));
    sc.Parameters.Add(new SqlParameter("@Name", l[1]));
    sc.Parameters.Add(new SqlParameter("@Subdivision", l[2]));
    sc.ExecuteNonQuery();
