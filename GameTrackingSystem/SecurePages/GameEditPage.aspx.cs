﻿using GameTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 @author: Vandit Kothari/Jose Mathew
    @date: June 21,2016
    @Website Name : gametrackingsystem@azurewebsites.net
    @This is Dashboard for signed in user.
    @version = 1.1
*/
namespace GameTrackingSystem
{
    public partial class GameEditPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ConnectionToDB();
        }
        protected void ConnectionToDB()
        {
            using (VJKMConnection db = new VJKMConnection())
            {
                var gameEdit = (from allgames in db.Games
                                select allgames);

                // bind the result to the GridView
                GameGridView.DataSource = gameEdit.AsQueryable().ToList();
                GameGridView.DataBind();
            }
        }
        protected void GameGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // store which row was clicked
            int selectedRow = e.RowIndex;

            // get the selected GameId using the Grid's DataKey collection
            int GameID = Convert.ToInt32(GameGridView.DataKeys[selectedRow].Values["GameID"]);

            // use EF to find the selected game in the DB and remove it
            using (VJKMConnection db = new VJKMConnection())
            {
                // create object of the game class and store the query string inside of it
                Game deletedGame = (from GameRecords in db.Games
                                          where GameRecords.GameID == GameID
                                          select GameRecords).FirstOrDefault();

                // remove the selected game from the db
                db.Games.Remove(deletedGame);

                // save my changes back to the database
                db.SaveChanges();

                // refresh the grid
                this.ConnectionToDB();
            }
        }
    }
}