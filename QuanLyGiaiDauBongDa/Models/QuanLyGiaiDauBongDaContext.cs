using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class QuanLyGiaiDauBongDaContext : DbContext
    {
        public QuanLyGiaiDauBongDaContext()
        {
        }

        public QuanLyGiaiDauBongDaContext(DbContextOptions<QuanLyGiaiDauBongDaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<MatchResult> MatchResults { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<PlayingPosition> PlayingPositions { get; set; }
        public virtual DbSet<Ranking> Rankings { get; set; }
        public virtual DbSet<Ranking2> Ranking2s { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Referee> Referees { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleAccount> RoleAccounts { get; set; }
        public virtual DbSet<Stadium> Stadia { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=(local); database=QuanLyGiaiDauBongDa; uid=nva1503; pwd=1503;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("Account");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.ClubId).HasColumnName("club_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .HasColumnName("full_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.HasOne(d => d.Club)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.ClubId)
                    .HasConstraintName("FK_Account_Club");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Card");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CardTime).HasColumnName("card_time");

                entity.Property(e => e.CardType).HasColumnName("card_type");

                entity.Property(e => e.MatchId).HasColumnName("match_id");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Card_Match");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Card_Player");
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.ToTable("Club");

                entity.Property(e => e.ClubId).HasColumnName("club_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.LogoUrl)
                    .HasMaxLength(50)
                    .HasColumnName("logo_url");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.StadiumId).HasColumnName("stadium_id");

                entity.Property(e => e.YearCreated)
                    .HasMaxLength(4)
                    .HasColumnName("year_created");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Clubs)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Club_Country");

                entity.HasOne(d => d.Stadium)
                    .WithMany(p => p.Clubs)
                    .HasForeignKey(d => d.StadiumId)
                    .HasConstraintName("FK_Club_Stadiun");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .HasColumnName("short_name");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("content");

                entity.Property(e => e.Problem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("problem");

                entity.Property(e => e.RateId).HasColumnName("rateId");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.Rate)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.RateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Rate");
            });

            modelBuilder.Entity<Goal>(entity =>
            {
                entity.ToTable("Goal");

                entity.Property(e => e.GoalId).HasColumnName("goal_id");

                entity.Property(e => e.GoalTime).HasColumnName("goal_time");

                entity.Property(e => e.MatchId).HasColumnName("match_id");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Goal_Match");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Goal_Player");
            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.ToTable("Match");

                entity.Property(e => e.MatchId).HasColumnName("match_id");

                entity.Property(e => e.GuestId).HasColumnName("guest_id");

                entity.Property(e => e.HostId).HasColumnName("host_id");

                entity.Property(e => e.PlayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("play_date");

                entity.Property(e => e.PlayStage)
                    .HasMaxLength(50)
                    .HasColumnName("play_stage");

                entity.Property(e => e.RefereeId).HasColumnName("referee_id");

                entity.Property(e => e.TourseasonId).HasColumnName("tourseason_id");

                entity.Property(e => e.VenueId).HasColumnName("venue_id");

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.MatchGuests)
                    .HasForeignKey(d => d.GuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Club1");

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.MatchHosts)
                    .HasForeignKey(d => d.HostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Club");

                entity.HasOne(d => d.Referee)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.RefereeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Referee");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.VenueId)
                    .HasConstraintName("FK_Match_Venue");
            });

            modelBuilder.Entity<MatchResult>(entity =>
            {
                entity.HasKey(e => new { e.MatchId, e.ClubId });

                entity.ToTable("Match_Result");

                entity.Property(e => e.MatchId).HasColumnName("match_id");

                entity.Property(e => e.ClubId).HasColumnName("club_id");

                entity.Property(e => e.Control).HasColumnName("control");

                entity.Property(e => e.Corners).HasColumnName("corners");

                entity.Property(e => e.Fouls).HasColumnName("fouls");

                entity.Property(e => e.GoalScore).HasColumnName("goal_score");

                entity.Property(e => e.Offsides).HasColumnName("offsides");

                entity.Property(e => e.Ontarget).HasColumnName("ontarget");

                entity.Property(e => e.PlayStage)
                    .HasMaxLength(50)
                    .HasColumnName("play_stage");

                entity.Property(e => e.Shots).HasColumnName("shots");

                entity.Property(e => e.WinLose)
                    .HasMaxLength(50)
                    .HasColumnName("win_lose");

                entity.HasOne(d => d.Club)
                    .WithMany(p => p.MatchResults)
                    .HasForeignKey(d => d.ClubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Result_Club");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.MatchResults)
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Result_Match");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("Player");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.ClubId).HasColumnName("club_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Dob)
                    .HasMaxLength(50)
                    .HasColumnName("dob");

                entity.Property(e => e.Height)
                    .HasMaxLength(50)
                    .HasColumnName("height");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.PositionId)
                    .HasMaxLength(50)
                    .HasColumnName("position_id");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .HasColumnName("weight");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_Player_Playing_Position");
            });

            modelBuilder.Entity<PlayingPosition>(entity =>
            {
                entity.HasKey(e => e.PositionId);

                entity.ToTable("Playing_Position");

                entity.Property(e => e.PositionId)
                    .HasMaxLength(50)
                    .HasColumnName("position_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Ranking>(entity =>
            {
                entity.HasKey(e => e.ClubId);

                entity.ToTable("Ranking");

                entity.Property(e => e.ClubId)
                    .ValueGeneratedNever()
                    .HasColumnName("club_id");

                entity.Property(e => e.ClubName)
                    .HasMaxLength(50)
                    .HasColumnName("club_name");

                entity.Property(e => e.Drawn).HasColumnName("drawn");

                entity.Property(e => e.GoalDifference).HasColumnName("goal_difference");

                entity.Property(e => e.Lost).HasColumnName("lost");

                entity.Property(e => e.MatchPlayed).HasColumnName("match_played");

                entity.Property(e => e.Won).HasColumnName("won");

                entity.HasOne(d => d.Club)
                    .WithOne(p => p.Ranking)
                    .HasForeignKey<Ranking>(d => d.ClubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ranking_Club1");
            });

            modelBuilder.Entity<Ranking2>(entity =>
            {
                entity.Property(e => e.Ranking2Id)
                    .HasMaxLength(50)
                    .HasColumnName("Ranking2ID");

                entity.Property(e => e.ClubId)
                    .HasMaxLength(10)
                    .HasColumnName("ClubID")
                    .IsFixedLength(true);

                entity.Property(e => e.ClubName).HasMaxLength(50);

                entity.Property(e => e.Drawn)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Gd)
                    .HasMaxLength(10)
                    .HasColumnName("GD")
                    .IsFixedLength(true);

                entity.Property(e => e.Lost)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Played)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Point).HasMaxLength(50);

                entity.Property(e => e.Won)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.ToTable("Rate");

                entity.Property(e => e.RateId)
                    .ValueGeneratedNever()
                    .HasColumnName("rateId");

                entity.Property(e => e.RateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rateName");
            });

            modelBuilder.Entity<Referee>(entity =>
            {
                entity.ToTable("Referee");

                entity.Property(e => e.RefereeId).HasColumnName("referee_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.RefereeName)
                    .HasMaxLength(50)
                    .HasColumnName("referee_name");

                entity.Property(e => e.YearStarted).HasColumnName("year_started");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Referees)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Referee_Country");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("role_id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<RoleAccount>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.Username });

                entity.ToTable("Role_Account");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAccounts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Account_Role");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.RoleAccounts)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Account_Account");
            });

            modelBuilder.Entity<Stadium>(entity =>
            {
                entity.ToTable("Stadium");

                entity.Property(e => e.StadiumId).HasColumnName("stadium_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.MatchId });

                entity.ToTable("Team");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.MatchId).HasColumnName("match_id");

                entity.Property(e => e.Starting).HasColumnName("starting");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_Match");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_Player");
            });

            modelBuilder.Entity<Venue>(entity =>
            {
                entity.ToTable("Venue");

                entity.Property(e => e.VenueId).HasColumnName("venue_id");

                entity.Property(e => e.AudienceCapacity).HasColumnName("audience_capacity");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
