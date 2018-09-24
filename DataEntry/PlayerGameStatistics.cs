private void playerGameStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "player-game-statistics.csv | player-game-statistics.csv"; //Chage this to PlayerGameStatistics.csv (on both)
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
                SqlCommand sc = new SqlCommand("insert into PlayerGameStatistics (PlayerGameStatisticsID,PlayerCode,GameCode,RushAtt,RushYard,RushTD,PassAtt,PassComp,PassYard,PassTD,PassInt,PassConv,Rec,RecYards,RecTD,KickoffRet,KickoffRetYard,KickoffRetTD,PuntRet,PuntRetYard,PuntRetTD,FumRet,FumRetYard,FumRetTD,IntRet,IntRetYard,IntRetTD,MiscRet,MiscRetYard,MiscRetTD,FieldGoalAtt,FieldGoalMade,OffXPKickAtt,OffXPKickAttMade,Off2XPMade,Def2XPAtt,Def2XPMade,Safety,Points,Punt,PuntYard,Kickoff,KickoffYard,KickoffTouchback,KickoffOutofBounds,KickoffOnside,Fumble,FumbleLost,TackleSolo,TackleAssist,TackleForLoss,TackleForLossYard,Sack,SackYard,QBHurry,FumbleForced,PassBrokenUp,KickPuntBlocked) VALUES (newid(),@PlayerCode,@GameCode,@RushAtt,@RushYard,@RushTD,@PassAtt,@PassComp,@PassYard,@PassTD,@PassInt,@PassConv,@Rec,@RecYards,@RecTD,@KickoffRet,@KickoffRetYard,@KickoffRetTD,@PuntRet,@PuntRetYard,@PuntRetTD,@FumRet,@FumRetYard,@FumRetTD,@IntRet,@IntRetYard,@IntRetTD,@MiscRet,@MiscRetYard,@MiscRetTD,@FieldGoalAtt,@FieldGoalMade,@OffXPKickAtt,@OffXPKickAttMade,@Off2XPMade,@Def2XPAtt,@Def2XPMade,@Safety,@Points,@Punt,@PuntYard,@Kickoff,@KickoffYard,@KickoffTouchback,@KickoffOutofBounds,@KickoffOnside,@Fumble,@FumbleLost,@TackleSolo,@TackleAssist,@TackleForLoss,@TackleForLossYard,@Sack,@SackYard,@QBHurry,@FumbleForced,@PassBrokenUp,@KickPuntBlocked)", SqlStuff.theConnection);
                sc.Parameters.Add(new SqlParameter("@PlayerCode", l[0]));
                sc.Parameters.Add(new SqlParameter("@GameCode", l[1]));
                sc.Parameters.Add(new SqlParameter("@RushAtt", l[2]));
                sc.Parameters.Add(new SqlParameter("@RushYard", l[3]));
                sc.Parameters.Add(new SqlParameter("@RushTD", l[4]));
                sc.Parameters.Add(new SqlParameter("@PassAtt", l[5]));
                sc.Parameters.Add(new SqlParameter("@PassComp", l[6]));
                sc.Parameters.Add(new SqlParameter("@PassYard", l[7]));
                sc.Parameters.Add(new SqlParameter("@PassTD", l[8]));
                sc.Parameters.Add(new SqlParameter("@PassInt", l[9]));
                sc.Parameters.Add(new SqlParameter("@PassConv", l[10]));
                sc.Parameters.Add(new SqlParameter("@Rec", l[11]));
                sc.Parameters.Add(new SqlParameter("@RecYards", l[12]));
                sc.Parameters.Add(new SqlParameter("@RecTD", l[13]));
                sc.Parameters.Add(new SqlParameter("@KickoffRet", l[14]));
                sc.Parameters.Add(new SqlParameter("@KickoffRetYard", l[15]));
                sc.Parameters.Add(new SqlParameter("@KickoffRetTD", l[16]));
                sc.Parameters.Add(new SqlParameter("@PuntRet", l[17]));
                sc.Parameters.Add(new SqlParameter("@PuntRetYard", l[18]));
                sc.Parameters.Add(new SqlParameter("@PuntRetTD", l[19]));
                sc.Parameters.Add(new SqlParameter("@FumRet", l[20]));
                sc.Parameters.Add(new SqlParameter("@FumRetYard", l[21]));
                sc.Parameters.Add(new SqlParameter("@FumRetTD", l[22]));
                sc.Parameters.Add(new SqlParameter("@IntRet", l[23]));
                sc.Parameters.Add(new SqlParameter("@IntRetYard", l[24]));
                sc.Parameters.Add(new SqlParameter("@IntRetTD", l[25]));
                sc.Parameters.Add(new SqlParameter("@MiscRet", l[26]));
                sc.Parameters.Add(new SqlParameter("@MiscRetYard", l[27]));
                sc.Parameters.Add(new SqlParameter("@MiscRetTD", l[28]));
                sc.Parameters.Add(new SqlParameter("@FieldGoalAtt", l[29]));
                sc.Parameters.Add(new SqlParameter("@FieldGoalMade", l[30]));
                sc.Parameters.Add(new SqlParameter("@OffXPKickAtt", l[31]));
                sc.Parameters.Add(new SqlParameter("@OffXPKickAttMade", l[32]));
                sc.Parameters.Add(new SqlParameter("@Off2XPAtt", l[33]));
                sc.Parameters.Add(new SqlParameter("@Off2XPMade", l[34]));
                sc.Parameters.Add(new SqlParameter("@Def2XPAtt", l[35]));
                sc.Parameters.Add(new SqlParameter("@Def2XPMade", l[36]));
                sc.Parameters.Add(new SqlParameter("@Safety", l[37]));
                sc.Parameters.Add(new SqlParameter("@Points", l[38]));
                sc.Parameters.Add(new SqlParameter("@Punt", l[39]));
                sc.Parameters.Add(new SqlParameter("@PuntYard", l[40]));
                sc.Parameters.Add(new SqlParameter("@Kickoff", l[41]));
                sc.Parameters.Add(new SqlParameter("@KickoffYard", l[42]));
                sc.Parameters.Add(new SqlParameter("@KickoffTouchback", l[43]));
                sc.Parameters.Add(new SqlParameter("@KickoffOutOfBounds", l[44]));
                sc.Parameters.Add(new SqlParameter("@KickoffOnside", l[45]));
                sc.Parameters.Add(new SqlParameter("@Fumble", l[46]));
                sc.Parameters.Add(new SqlParameter("@FumbleLost", l[47]));
                sc.Parameters.Add(new SqlParameter("@TackleSolo", l[48]));
                sc.Parameters.Add(new SqlParameter("@TackleAssist", l[49]));
                sc.Parameters.Add(new SqlParameter("@TackleForLoss", l[50]));
                sc.Parameters.Add(new SqlParameter("@TackleForLossYard", l[51]));
                sc.Parameters.Add(new SqlParameter("@Sack", l[52]));
                sc.Parameters.Add(new SqlParameter("@SackYard", l[53]));
                sc.Parameters.Add(new SqlParameter("@QBHurry", l[54]));
                sc.Parameters.Add(new SqlParameter("@FumbleForced", l[55]));
                sc.Parameters.Add(new SqlParameter("@PassBrokenUp", l[56]));
                sc.Parameters.Add(new SqlParameter("@KickPuntBlocked", l[57]));
                sc.ExecuteNonQuery();
            }
        }
