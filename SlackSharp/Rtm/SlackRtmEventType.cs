using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SlackSharp.Rtm
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SlackRtmEventType
    {
        [EnumMember(Value = "hello")]
        Hello,

        [EnumMember(Value = "message")]
        Message,

        [EnumMember(Value = "user_typing")]
        UserTyping,

        [EnumMember(Value = "channel_marked")]
        ChannelMarked,

        [EnumMember(Value = "channel_created")]
        ChannelCreated,

        [EnumMember(Value = "channel_joined")]
        ChannelJoined,

        [EnumMember(Value = "channel_left")]
        ChannelLeft,

        [EnumMember(Value = "channel_deleted")]
        ChannelDeleted,

        [EnumMember(Value = "channel_rename")]
        ChannelRename,

        [EnumMember(Value = "channel_archive")]
        ChannelArchive,

        [EnumMember(Value = "channel_unarchive")]
        ChannelUnarchive,

        [EnumMember(Value = "channel_history_changed")]
        ChannelHistoryChanged,

        [EnumMember(Value = "dnd_updated")]
        DndUpdated,

        [EnumMember(Value = "dnd_updated_user")]
        DndUpdatedUser,

        [EnumMember(Value = "im_created")]
        ImCreated,

        [EnumMember(Value = "im_open")]
        ImOpen,

        [EnumMember(Value = "im_close")]
        ImClose,

        [EnumMember(Value = "im_marked")]
        ImMarked,

        [EnumMember(Value = "im_history_changed")]
        ImHistoryChanged,

        [EnumMember(Value = "group_joined")]
        GroupJoined,

        [EnumMember(Value = "group_left")]
        GroupLeft,

        [EnumMember(Value = "group_open")]
        GroupOpen,

        [EnumMember(Value = "group_close")]
        GroupClose,

        [EnumMember(Value = "group_archive")]
        GroupArchive,

        [EnumMember(Value = "group_unarchive")]
        GroupUnarchive,

        [EnumMember(Value = "group_rename")]
        GroupRename,

        [EnumMember(Value = "group_marked")]
        GroupMarked,

        [EnumMember(Value = "group_history_changed")]
        GroupHistoryChanged,

        [EnumMember(Value = "file_created")]
        FileCreated,

        [EnumMember(Value = "file_shared")]
        FileShared,

        [EnumMember(Value = "file_unshared")]
        FileUnshared,

        [EnumMember(Value = "file_public")]
        FilePublic,

        [EnumMember(Value = "file_private")]
        FilePrivate,

        [EnumMember(Value = "file_change")]
        FileChange,

        [EnumMember(Value = "file_deleted")]
        FileDeleted,

        [EnumMember(Value = "file_comment_added")]
        FileCommentAdded,

        [EnumMember(Value = "file_comment_edited")]
        FileCommentEdited,

        [EnumMember(Value = "file_comment_deleted")]
        FileCommentDeleted,

        [EnumMember(Value = "pin_added")]
        PinAdded,

        [EnumMember(Value = "pin_removed")]
        PinRemoved,

        [EnumMember(Value = "presence_change")]
        PresenceChange,

        [EnumMember(Value = "manual_presence_change")]
        ManualPresenceChange,

        [EnumMember(Value = "pref_change")]
        PrefChange,

        [EnumMember(Value = "user_change")]
        UserChange,

        [EnumMember(Value = "team_join")]
        TeamJoin,

        [EnumMember(Value = "star_added")]
        StarAdded,

        [EnumMember(Value = "star_removed")]
        StarRemoved,

        [EnumMember(Value = "reaction_added")]
        ReactionAdded,

        [EnumMember(Value = "reaction_removed")]
        ReactionRemoved,

        [EnumMember(Value = "emoji_changed")]
        EmojiChanged,

        [EnumMember(Value = "commands_changed")]
        CommandsChanged,

        [EnumMember(Value = "team_plan_change")]
        TeamPlanChange,

        [EnumMember(Value = "team_pref_change")]
        TeamPrefChange,

        [EnumMember(Value = "team_rename")]
        TeamRename,

        [EnumMember(Value = "team_domain_change")]
        TeamDomainChange,

        [EnumMember(Value = "email_domain_changed")]
        EmailDomainChange,

        [EnumMember(Value = "team_profile_change")]
        TeamProfileChange,

        [EnumMember(Value = "team_profile_delete")]
        TeamProfileDelete,

        [EnumMember(Value = "team_profile_reorder")]
        TeamProfileReorder,

        [EnumMember(Value = "bot_added")]
        BotAdded,

        [EnumMember(Value = "bot_changed")]
        BotChanged,

        [EnumMember(Value = "accounts_changed")]
        AccountsChanged,

        [EnumMember(Value = "team_migration_started")]
        TeamMigrationStarted,

        [EnumMember(Value = "reconnect_url")]
        ReconnectUrl,

        [EnumMember(Value = "subteam_created")]
        SubteamCreated,

        [EnumMember(Value = "subteam_updated")]
        SubteamUpdated,

        [EnumMember(Value = "subteam_self_added")]
        SubteamSelfAdded,

        [EnumMember(Value = "subteam_self_removed")]
        SubteamSelfRemoved

    }
}
