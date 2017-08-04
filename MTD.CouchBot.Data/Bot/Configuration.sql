﻿CREATE TABLE [Bot].[Configuration]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[DiscordToken] NVARCHAR(128) NOT NULL,
	[YouTubeApiKey] NVARCHAR(128) NOT NULL,
	[TwitchClientId] NVARCHAR(32) NOT NULL,
	[ApiAiKey] NVARCHAR(128) NOT NULL,
	[BotId] NVARCHAR(32) NOT NULL,
	[Prefix] NVARCHAR(8) NOT NULL,
	[TotalShards] INT NOT NULL,
	[OwnerId] NVARCHAR(32) NOT NULL,
	[EnableMixer] BIT NOT NULL,
	[EnableSmashcast] BIT NOT NULL,
	[EnablePicarto] BIT NOT NULL,
	[EnableTwitch] BIT NOT NULL,
	[EnableYouTube] BIT NOT NULL,
	[EnableVidMe] BIT NOT NULL,
	[PicartoInterval] INT NOT NULL,
	[SmashcastInterval] INT NOT NULL,
	[TwitchInterval] INT NOT NULL,
	[TwitchFeedInterval] INT NOT NULL,
	[YouTubeLiveInterval] INT NOT NULL,
	[YouTubePublishedInterval] INT NOT NULL,
	[VidMeInterval] INT NOT NULL
)
