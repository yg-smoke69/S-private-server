using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20002D6")]
public static class EventLogger
{
	[Token(Token = "0x20002D7")]
	public class EventLoggerBase
	{
		[Token(Token = "0x40033D3")]
		[FieldOffset(Offset = "0x8")]
		public string region;

		[Token(Token = "0x40033D4")]
		[FieldOffset(Offset = "0x10")]
		public ulong account_id;

		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x22FE9FC", Offset = "0x22FE9FC", VA = "0x22FE9FC")]
		public EventLoggerBase()
		{
		}
	}

	[Token(Token = "0x20002D8")]
	public class EventTypeVeteranSplashBanner : EventLoggerBase
	{
		[Token(Token = "0x40033D5")]
		[FieldOffset(Offset = "0x18")]
		public uint goto_pos;

		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x22E5BAC", Offset = "0x22E5BAC", VA = "0x22E5BAC")]
		public EventTypeVeteranSplashBanner()
		{
		}
	}

	[Token(Token = "0x20002D9")]
	public class EventTypeClipboardFeedback : EventLoggerBase
	{
		[Token(Token = "0x40033D6")]
		[FieldOffset(Offset = "0x18")]
		public int timing;

		[Token(Token = "0x40033D7")]
		[FieldOffset(Offset = "0x1C")]
		public int process_method;

		[Token(Token = "0x40033D8")]
		[FieldOffset(Offset = "0x20")]
		public int area;

		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x22FEBA4", Offset = "0x22FEBA4", VA = "0x22FEBA4")]
		public EventTypeClipboardFeedback()
		{
		}
	}

	[Token(Token = "0x20002DA")]
	public class EventTypeBigEventCumulativeSigninDayReward : EventLoggerBase
	{
		[Token(Token = "0x40033D9")]
		[FieldOffset(Offset = "0x18")]
		public List<AwardDesc> awards;

		[Token(Token = "0x40033DA")]
		[FieldOffset(Offset = "0x1C")]
		public uint cur_cumulative_num;

		[Token(Token = "0x40033DB")]
		[FieldOffset(Offset = "0x20")]
		public uint event_id;

		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x22FEB9C", Offset = "0x22FEB9C", VA = "0x22FEB9C")]
		public EventTypeBigEventCumulativeSigninDayReward()
		{
		}
	}

	[Token(Token = "0x20002DB")]
	public class EventTypeTutorialForceGuideProcedureInfo : EventLoggerBase
	{
		[Token(Token = "0x40033DC")]
		[FieldOffset(Offset = "0x18")]
		public uint id;

		[Token(Token = "0x40033DD")]
		[FieldOffset(Offset = "0x1C")]
		public uint time;

		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x22FEC2C", Offset = "0x22FEC2C", VA = "0x22FEC2C")]
		public EventTypeTutorialForceGuideProcedureInfo()
		{
		}
	}

	[Token(Token = "0x20002DC")]
	public class EventTypeRegisterForceGuideTrigger : EventLoggerBase
	{
		[Token(Token = "0x40033DE")]
		[FieldOffset(Offset = "0x18")]
		public bool if_force;

		[Token(Token = "0x40033DF")]
		[FieldOffset(Offset = "0x1C")]
		public int guide_type;

		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x22FEC0C", Offset = "0x22FEC0C", VA = "0x22FEC0C")]
		public EventTypeRegisterForceGuideTrigger()
		{
		}
	}

	[Token(Token = "0x20002DD")]
	public class EventTypeRegisterForceGuideComplete : EventLoggerBase
	{
		[Token(Token = "0x40033E0")]
		[FieldOffset(Offset = "0x18")]
		public int complete_type;

		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x22FEC04", Offset = "0x22FEC04", VA = "0x22FEC04")]
		public EventTypeRegisterForceGuideComplete()
		{
		}
	}

	[Token(Token = "0x20002DE")]
	public class EventTypeAvatarSkillSlotGuide : EventLoggerBase
	{
		[Token(Token = "0x40033E1")]
		[FieldOffset(Offset = "0x18")]
		public uint level;

		[Token(Token = "0x40033E2")]
		[FieldOffset(Offset = "0x1C")]
		public bool unlock_skill_slot_guide;

		[Token(Token = "0x40033E3")]
		[FieldOffset(Offset = "0x1D")]
		public bool equip_skill_slot_guide;

		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x22FEB8C", Offset = "0x22FEB8C", VA = "0x22FEB8C")]
		public EventTypeAvatarSkillSlotGuide()
		{
		}
	}

	[Token(Token = "0x20002DF")]
	public class EventTypeReservationSent : EventLoggerBase
	{
		[Token(Token = "0x40033E4")]
		[FieldOffset(Offset = "0x18")]
		public ulong received_account_id;

		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x22FEC24", Offset = "0x22FEC24", VA = "0x22FEC24")]
		public EventTypeReservationSent()
		{
		}
	}

	[Token(Token = "0x20002E0")]
	public class EventTypeReservationReply : EventLoggerBase
	{
		[Token(Token = "0x40033E5")]
		[FieldOffset(Offset = "0x18")]
		public ulong send_account_id;

		[Token(Token = "0x40033E6")]
		[FieldOffset(Offset = "0x20")]
		public bool action;

		[Token(Token = "0x40033E7")]
		[FieldOffset(Offset = "0x21")]
		public bool if_shield;

		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x22FEC1C", Offset = "0x22FEC1C", VA = "0x22FEC1C")]
		public EventTypeReservationReply()
		{
		}
	}

	[Token(Token = "0x20002E1")]
	public class EventTypeReservationConfirm : EventLoggerBase
	{
		[Token(Token = "0x40033E8")]
		[FieldOffset(Offset = "0x18")]
		public ulong received_account_id;

		[Token(Token = "0x40033E9")]
		[FieldOffset(Offset = "0x20")]
		public bool if_confirm;

		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x22FEC14", Offset = "0x22FEC14", VA = "0x22FEC14")]
		public EventTypeReservationConfirm()
		{
		}
	}

	[Token(Token = "0x20002E2")]
	public class EventTypeLimitedEventShare : EventLoggerBase
	{
		[Token(Token = "0x40033EA")]
		[FieldOffset(Offset = "0x18")]
		public bool share_out;

		[Token(Token = "0x40033EB")]
		[FieldOffset(Offset = "0x1C")]
		public uint platform;

		[Token(Token = "0x40033EC")]
		[FieldOffset(Offset = "0x20")]
		public uint event_id;

		[Token(Token = "0x40033ED")]
		[FieldOffset(Offset = "0x24")]
		public uint page_id;

		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x22FEBCC", Offset = "0x22FEBCC", VA = "0x22FEBCC")]
		public EventTypeLimitedEventShare()
		{
		}
	}

	[Token(Token = "0x20002E3")]
	public class EventTypeSplashBannerPopup : EventLoggerBase
	{
		[Token(Token = "0x40033EE")]
		[FieldOffset(Offset = "0x18")]
		public uint id;

		[Token(Token = "0x40033EF")]
		[FieldOffset(Offset = "0x1C")]
		public string network;

		[Token(Token = "0x40033F0")]
		[FieldOffset(Offset = "0x20")]
		public string network_type_a;

		[Token(Token = "0x40033F1")]
		[FieldOffset(Offset = "0x24")]
		public string system_software;

		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x22FC004", Offset = "0x22FC004", VA = "0x22FC004")]
		public EventTypeSplashBannerPopup()
		{
		}
	}

	[Token(Token = "0x20002E4")]
	public class EventTypeFourSymbolsPictureMatching : EventLoggerBase
	{
		[Token(Token = "0x40033F2")]
		[FieldOffset(Offset = "0x18")]
		public uint draw_time;

		[Token(Token = "0x40033F3")]
		[FieldOffset(Offset = "0x1C")]
		public uint draw_num;

		[Token(Token = "0x40033F4")]
		[FieldOffset(Offset = "0x20")]
		public uint symbol_id;

		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x22FEBB4", Offset = "0x22FEBB4", VA = "0x22FEBB4")]
		public EventTypeFourSymbolsPictureMatching()
		{
		}
	}

	[Token(Token = "0x20002E5")]
	public class EventTypeCloseUpShare : EventLoggerBase
	{
		[Token(Token = "0x40033F5")]
		[FieldOffset(Offset = "0x18")]
		public bool share_out;

		[Token(Token = "0x40033F6")]
		[FieldOffset(Offset = "0x1C")]
		public uint platform;

		[Token(Token = "0x40033F7")]
		[FieldOffset(Offset = "0x20")]
		public uint item_id;

		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x22FEBAC", Offset = "0x22FEBAC", VA = "0x22FEBAC")]
		public EventTypeCloseUpShare()
		{
		}
	}

	[Token(Token = "0x20002E6")]
	public class EventBannerClickLog : EventLoggerBase
	{
		[Token(Token = "0x40033F8")]
		[FieldOffset(Offset = "0x18")]
		public uint banner_type;

		[Token(Token = "0x40033F9")]
		[FieldOffset(Offset = "0x1C")]
		public uint banner_id;

		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x22FEA0C", Offset = "0x22FEA0C", VA = "0x22FEA0C")]
		public EventBannerClickLog()
		{
		}
	}

	[Token(Token = "0x20002E7")]
	public class EventObserverLog : EventLoggerBase
	{
		[Token(Token = "0x40033FA")]
		[FieldOffset(Offset = "0x18")]
		public float observer_time;

		[Token(Token = "0x40033FB")]
		[FieldOffset(Offset = "0x1C")]
		public uint switch_count;

		[Token(Token = "0x40033FC")]
		[FieldOffset(Offset = "0x20")]
		public bool click_close;

		[Token(Token = "0x40033FD")]
		[FieldOffset(Offset = "0x24")]
		public int group_mode;

		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x22FE0B8", Offset = "0x22FE0B8", VA = "0x22FE0B8")]
		public EventObserverLog()
		{
		}
	}

	[Token(Token = "0x20002E8")]
	public class EventTypeDefaultMusicClick : EventLoggerBase
	{
		[Token(Token = "0x40033FE")]
		[FieldOffset(Offset = "0x18")]
		public bool click_state;

		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x22FC514", Offset = "0x22FC514", VA = "0x22FC514")]
		public EventTypeDefaultMusicClick()
		{
		}
	}

	[Token(Token = "0x20002E9")]
	public class EventTypeDigitalUniverseConcertStats : EventLoggerBase
	{
		[Token(Token = "0x20002EA")]
		public class MiniGameInfo
		{
			[Token(Token = "0x4003401")]
			[FieldOffset(Offset = "0x8")]
			public int type;

			[Token(Token = "0x4003402")]
			[FieldOffset(Offset = "0xC")]
			public int sub_type;

			[Token(Token = "0x6000E5C")]
			[Address(RVA = "0x22F3978", Offset = "0x22F3978", VA = "0x22F3978")]
			public MiniGameInfo()
			{
			}
		}

		[Token(Token = "0x40033FF")]
		[FieldOffset(Offset = "0x18")]
		public bool is_drop;

		[Token(Token = "0x4003400")]
		[FieldOffset(Offset = "0x1C")]
		public readonly List<MiniGameInfo> game_infos;

		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x22F38EC", Offset = "0x22F38EC", VA = "0x22F38EC")]
		public EventTypeDigitalUniverseConcertStats()
		{
		}
	}

	[Token(Token = "0x20002EB")]
	public class EventTypeDigitalUniverseRotationStats : EventLoggerBase
	{
		[Token(Token = "0x4003403")]
		[FieldOffset(Offset = "0x18")]
		public bool is_rotate;

		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x22FC628", Offset = "0x22FC628", VA = "0x22FC628")]
		public EventTypeDigitalUniverseRotationStats()
		{
		}
	}

	[Token(Token = "0x20002EC")]
	public class EventTypeDigitalUniverseStarMapBehavior : EventLoggerBase
	{
		[Token(Token = "0x4003404")]
		[FieldOffset(Offset = "0x18")]
		public ulong behaviored_id;

		[Token(Token = "0x4003405")]
		[FieldOffset(Offset = "0x20")]
		public int type;

		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x22FC778", Offset = "0x22FC778", VA = "0x22FC778")]
		public EventTypeDigitalUniverseStarMapBehavior()
		{
		}
	}

	[Token(Token = "0x20002ED")]
	public class EventTypeDigitalUniverseStarMapValueChange : EventLoggerBase
	{
		[Token(Token = "0x4003406")]
		[FieldOffset(Offset = "0x18")]
		public int valueregion_id;

		[Token(Token = "0x4003407")]
		[FieldOffset(Offset = "0x20")]
		public ulong helped_id;

		[Token(Token = "0x4003408")]
		[FieldOffset(Offset = "0x28")]
		public uint cur_value;

		[Token(Token = "0x4003409")]
		[FieldOffset(Offset = "0x2C")]
		public uint pre_value;

		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x22FC900", Offset = "0x22FC900", VA = "0x22FC900")]
		public EventTypeDigitalUniverseStarMapValueChange()
		{
		}
	}

	[Token(Token = "0x20002EE")]
	public class EventTypeDigitalUniverseStarMapValueReward : EventLoggerBase
	{
		[Token(Token = "0x400340A")]
		[FieldOffset(Offset = "0x18")]
		public AwardDesc rewards;

		[Token(Token = "0x400340B")]
		[FieldOffset(Offset = "0x1C")]
		public uint target_id;

		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x22FCA34", Offset = "0x22FCA34", VA = "0x22FCA34")]
		public EventTypeDigitalUniverseStarMapValueReward()
		{
		}
	}

	[Token(Token = "0x20002EF")]
	public class EventLogPageDetentionTimeCached : EventLoggerBase
	{
		[Token(Token = "0x400340C")]
		[FieldOffset(Offset = "0x18")]
		public List<EventLogPageDetentionTimeItem> views;

		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x22F3560", Offset = "0x22F3560", VA = "0x22F3560")]
		public EventLogPageDetentionTimeCached()
		{
		}
	}

	[Token(Token = "0x20002F0")]
	public class EventLogPageDetentionTimeItem
	{
		[Token(Token = "0x400340D")]
		[FieldOffset(Offset = "0x8")]
		public string page_name;

		[Token(Token = "0x400340E")]
		[FieldOffset(Offset = "0xC")]
		public int view_time;

		[Token(Token = "0x400340F")]
		[FieldOffset(Offset = "0x10")]
		public int cnt;

		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x22F3568", Offset = "0x22F3568", VA = "0x22F3568")]
		public EventLogPageDetentionTimeItem()
		{
		}
	}

	[Token(Token = "0x20002F1")]
	public class EventPageDetentionTime : EventLoggerBase
	{
		[Token(Token = "0x4003410")]
		[FieldOffset(Offset = "0x18")]
		public string page_name;

		[Token(Token = "0x4003411")]
		[FieldOffset(Offset = "0x1C")]
		public int view_time;

		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x22FEB0C", Offset = "0x22FEB0C", VA = "0x22FEB0C")]
		public EventPageDetentionTime()
		{
		}
	}

	[Token(Token = "0x20002F2")]
	public class EventProfilePageViewTime : EventPageDetentionTime
	{
		[Token(Token = "0x4003412")]
		[FieldOffset(Offset = "0x20")]
		public ulong viewed_id;

		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x22FEB1C", Offset = "0x22FEB1C", VA = "0x22FEB1C")]
		public EventProfilePageViewTime()
		{
		}
	}

	[Token(Token = "0x20002F3")]
	public class EventCilckHistoryStats : EventLoggerBase
	{
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x22FEA2C", Offset = "0x22FEA2C", VA = "0x22FEA2C")]
		public EventCilckHistoryStats()
		{
		}
	}

	[Token(Token = "0x20002F4")]
	public class EventIOSIDFA : EventLoggerBase
	{
		[Token(Token = "0x4003413")]
		[FieldOffset(Offset = "0x18")]
		public string open_id;

		[Token(Token = "0x4003414")]
		[FieldOffset(Offset = "0x1C")]
		public string idfa;

		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x22F06F8", Offset = "0x22F06F8", VA = "0x22F06F8")]
		public EventIOSIDFA()
		{
		}
	}

	[Token(Token = "0x20002F5")]
	public class EventAddFriendInHistoryStats : EventLoggerBase
	{
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x22FEA04", Offset = "0x22FEA04", VA = "0x22FEA04")]
		public EventAddFriendInHistoryStats()
		{
		}
	}

	[Token(Token = "0x20002F6")]
	public class EventClickRewardedVideo : EventLoggerBase
	{
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x22FEA34", Offset = "0x22FEA34", VA = "0x22FEA34")]
		public EventClickRewardedVideo()
		{
		}
	}

	[Token(Token = "0x20002F7")]
	public class EventGroupInvite : EventLoggerBase
	{
		[Token(Token = "0x4003415")]
		[FieldOffset(Offset = "0x18")]
		public ulong inviter;

		[Token(Token = "0x4003416")]
		[FieldOffset(Offset = "0x20")]
		public ulong invitee;

		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x22FEA5C", Offset = "0x22FEA5C", VA = "0x22FEA5C")]
		public EventGroupInvite()
		{
		}
	}

	[Token(Token = "0x20002F8")]
	public class EventGroupInviteOperation : EventLoggerBase
	{
		[Token(Token = "0x4003417")]
		[FieldOffset(Offset = "0x18")]
		public uint oper_type;

		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x22E5E80", Offset = "0x22E5E80", VA = "0x22E5E80")]
		public EventGroupInviteOperation()
		{
		}
	}

	[Token(Token = "0x20002F9")]
	public class EventTypeGroupInviteWithinClient : EventGroupInvite
	{
		[Token(Token = "0x4003418")]
		[FieldOffset(Offset = "0x28")]
		public uint channel;

		[Token(Token = "0x4003419")]
		[FieldOffset(Offset = "0x2C")]
		public uint invitee_type;

		[Token(Token = "0x400341A")]
		[FieldOffset(Offset = "0x30")]
		public ulong group_id;

		[Token(Token = "0x400341B")]
		[FieldOffset(Offset = "0x38")]
		public uint match_mode;

		[Token(Token = "0x400341C")]
		[FieldOffset(Offset = "0x3C")]
		public uint game_mode;

		[Token(Token = "0x400341D")]
		[FieldOffset(Offset = "0x40")]
		public uint group_mode;

		[Token(Token = "0x400341E")]
		[FieldOffset(Offset = "0x44")]
		public uint[] map_ids;

		[Token(Token = "0x400341F")]
		[FieldOffset(Offset = "0x48")]
		public uint group_type;

		[Token(Token = "0x4003420")]
		[FieldOffset(Offset = "0x4C")]
		public uint group_size;

		[Token(Token = "0x4003421")]
		[FieldOffset(Offset = "0x50")]
		public uint result;

		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x22FEBC4", Offset = "0x22FEBC4", VA = "0x22FEBC4")]
		public EventTypeGroupInviteWithinClient()
		{
		}
	}

	[Token(Token = "0x20002FA")]
	public class EventSplashBannerGoto : EventLoggerBase
	{
		[Token(Token = "0x4003422")]
		[FieldOffset(Offset = "0x18")]
		public uint id;

		[Token(Token = "0x4003423")]
		[FieldOffset(Offset = "0x1C")]
		public uint goto_pos;

		[Token(Token = "0x4003424")]
		[FieldOffset(Offset = "0x20")]
		public string goto_url;

		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x22E5878", Offset = "0x22E5878", VA = "0x22E5878")]
		public EventSplashBannerGoto()
		{
		}
	}

	[Token(Token = "0x20002FB")]
	public class EventSplashBannerPush : EventLoggerBase
	{
		[Token(Token = "0x4003425")]
		[FieldOffset(Offset = "0x18")]
		public bool state;

		[Token(Token = "0x4003426")]
		[FieldOffset(Offset = "0x1C")]
		public uint entry_id;

		[Token(Token = "0x4003427")]
		[FieldOffset(Offset = "0x20")]
		public uint event_id;

		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x22E5D6C", Offset = "0x22E5D6C", VA = "0x22E5D6C")]
		public EventSplashBannerPush()
		{
		}
	}

	[Token(Token = "0x20002FC")]
	public class EventWaitingForMatchmaking_RuntimeData
	{
		[Token(Token = "0x4003428")]
		[FieldOffset(Offset = "0x8")]
		public float TimeStart;

		[Token(Token = "0x4003429")]
		[FieldOffset(Offset = "0xC")]
		public uint GroupMode;

		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x22FE088", Offset = "0x22FE088", VA = "0x22FE088")]
		public EventWaitingForMatchmaking_RuntimeData()
		{
		}
	}

	[Token(Token = "0x20002FD")]
	public class EventReloadWeapon : EventLoggerBase
	{
		[Token(Token = "0x400342A")]
		[FieldOffset(Offset = "0x18")]
		public uint weapon_data_id;

		[Token(Token = "0x400342B")]
		[FieldOffset(Offset = "0x1C")]
		public uint ammo_in_clip;

		[Token(Token = "0x400342C")]
		[FieldOffset(Offset = "0x20")]
		public uint ammo_capacity;

		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x22FEB34", Offset = "0x22FEB34", VA = "0x22FEB34")]
		public EventReloadWeapon()
		{
		}
	}

	[Token(Token = "0x20002FE")]
	public class EventReturnLobbyAfterDeath : EventLoggerBase
	{
		[Token(Token = "0x400342D")]
		[FieldOffset(Offset = "0x18")]
		public uint time_to_wait;

		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x22FEB44", Offset = "0x22FEB44", VA = "0x22FEB44")]
		public EventReturnLobbyAfterDeath()
		{
		}
	}

	[Token(Token = "0x20002FF")]
	public class EventReturnLobbyAfterDeath_RuntimeData
	{
		[Token(Token = "0x400342E")]
		[FieldOffset(Offset = "0x8")]
		public float TimeDeath;

		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x22FE078", Offset = "0x22FE078", VA = "0x22FE078")]
		public EventReturnLobbyAfterDeath_RuntimeData()
		{
		}
	}

	[Token(Token = "0x2000300")]
	public class EventOpOnBag : EventLoggerBase
	{
		[Token(Token = "0x400342F")]
		[FieldOffset(Offset = "0x18")]
		public uint pickup_data_id;

		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x22FEB04", Offset = "0x22FEB04", VA = "0x22FEB04")]
		public EventOpOnBag()
		{
		}
	}

	[Token(Token = "0x2000301")]
	public class EventOpOnBag_RuntimeData
	{
		[Token(Token = "0x4003430")]
		[FieldOffset(Offset = "0x8")]
		public float TimePickup;

		[Token(Token = "0x4003431")]
		[FieldOffset(Offset = "0xC")]
		public uint PickupItemDataID;

		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x22FE080", Offset = "0x22FE080", VA = "0x22FE080")]
		public EventOpOnBag_RuntimeData()
		{
		}
	}

	[Token(Token = "0x2000302")]
	public class EventAddFriendActively : EventLoggerBase
	{
		[Token(Token = "0x4003432")]
		[FieldOffset(Offset = "0x18")]
		public ulong friend_account_id;

		[Token(Token = "0x4003433")]
		[FieldOffset(Offset = "0x20")]
		public string add_from;

		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x22E6514", Offset = "0x22E6514", VA = "0x22E6514")]
		public EventAddFriendActively()
		{
		}
	}

	[Token(Token = "0x2000303")]
	public class EventLogBRTutorialLobbyGuide : EventLoggerBase
	{
		[Token(Token = "0x4003434")]
		[FieldOffset(Offset = "0x18")]
		public bool if_force;

		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x22E6628", Offset = "0x22E6628", VA = "0x22E6628")]
		public EventLogBRTutorialLobbyGuide()
		{
		}
	}

	[Token(Token = "0x2000304")]
	public class EventLogBRRankLevelChange : EventLoggerBase
	{
		[Token(Token = "0x4003435")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x4003436")]
		[FieldOffset(Offset = "0x20")]
		public uint pre_rank;

		[Token(Token = "0x4003437")]
		[FieldOffset(Offset = "0x24")]
		public uint pre_level;

		[Token(Token = "0x4003438")]
		[FieldOffset(Offset = "0x28")]
		public int pre_ranking_points;

		[Token(Token = "0x4003439")]
		[FieldOffset(Offset = "0x2C")]
		public uint cur_rank;

		[Token(Token = "0x400343A")]
		[FieldOffset(Offset = "0x30")]
		public uint cur_level;

		[Token(Token = "0x400343B")]
		[FieldOffset(Offset = "0x34")]
		public int cur_ranking_points;

		[Token(Token = "0x400343C")]
		[FieldOffset(Offset = "0x38")]
		public uint season_id;

		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x22EDAC8", Offset = "0x22EDAC8", VA = "0x22EDAC8")]
		public EventLogBRRankLevelChange()
		{
		}
	}

	[Token(Token = "0x2000305")]
	public class EventAddFriendActively_RuntimeData
	{
		[Token(Token = "0x400343D")]
		[FieldOffset(Offset = "0x8")]
		public bool IsSearch;

		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x22FE090", Offset = "0x22FE090", VA = "0x22FE090")]
		public EventAddFriendActively_RuntimeData()
		{
		}
	}

	[Token(Token = "0x2000306")]
	public class EventReport : EventLoggerBase
	{
		[Token(Token = "0x400343E")]
		[FieldOffset(Offset = "0x18")]
		public ulong reportee;

		[Token(Token = "0x400343F")]
		[FieldOffset(Offset = "0x20")]
		public uint reason;

		[Token(Token = "0x4003440")]
		[FieldOffset(Offset = "0x28")]
		public ulong match_id;

		[Token(Token = "0x4003441")]
		[FieldOffset(Offset = "0x30")]
		public uint map_id;

		[Token(Token = "0x4003442")]
		[FieldOffset(Offset = "0x34")]
		public uint game_mode;

		[Token(Token = "0x4003443")]
		[FieldOffset(Offset = "0x38")]
		public uint group_mode;

		[Token(Token = "0x4003444")]
		[FieldOffset(Offset = "0x3C")]
		public uint match_mode;

		[Token(Token = "0x4003445")]
		[FieldOffset(Offset = "0x40")]
		public ulong teammate_1;

		[Token(Token = "0x4003446")]
		[FieldOffset(Offset = "0x48")]
		public ulong teammate_2;

		[Token(Token = "0x4003447")]
		[FieldOffset(Offset = "0x50")]
		public ulong teammate_3;

		[Token(Token = "0x4003448")]
		[FieldOffset(Offset = "0x58")]
		public uint is_special;

		[Token(Token = "0x4003449")]
		[FieldOffset(Offset = "0x5C")]
		public uint[] sub_reason;

		[Token(Token = "0x400344A")]
		[FieldOffset(Offset = "0x60")]
		public bool is_emulator;

		[Token(Token = "0x400344B")]
		[FieldOffset(Offset = "0x64")]
		public uint report_scene;

		[Token(Token = "0x400344C")]
		[FieldOffset(Offset = "0x68")]
		public uint reportee_type;

		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x22ECC34", Offset = "0x22ECC34", VA = "0x22ECC34")]
		public EventReport()
		{
		}
	}

	[Token(Token = "0x2000307")]
	public class EventWeaponSkinInfo : EventLoggerBase
	{
		[Token(Token = "0x400344D")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x400344E")]
		[FieldOffset(Offset = "0x20")]
		public string weapon_skins;

		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x22FF018", Offset = "0x22FF018", VA = "0x22FF018")]
		public EventWeaponSkinInfo()
		{
		}
	}

	[Token(Token = "0x2000308")]
	public class EventWeaponEquip : EventLoggerBase
	{
		[Token(Token = "0x400344F")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x4003450")]
		[FieldOffset(Offset = "0x20")]
		public uint weapon_id;

		[Token(Token = "0x4003451")]
		[FieldOffset(Offset = "0x24")]
		public uint collection_id;

		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x22FF010", Offset = "0x22FF010", VA = "0x22FF010")]
		public EventWeaponEquip()
		{
		}
	}

	[Token(Token = "0x2000309")]
	public class EventSettingChangeLog : EventLoggerBase
	{
		[Token(Token = "0x4003452")]
		[FieldOffset(Offset = "0x18")]
		public List<string> changed_Settings;

		[Token(Token = "0x4003453")]
		[FieldOffset(Offset = "0x1C")]
		public bool is_ingame;

		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x22FEB54", Offset = "0x22FEB54", VA = "0x22FEB54")]
		public EventSettingChangeLog()
		{
		}
	}

	[Token(Token = "0x200030A")]
	public class EventTypeAutoPopupWindowCtrl : EventLoggerBase
	{
		[Token(Token = "0x4003454")]
		[FieldOffset(Offset = "0x18")]
		public uint random_result;

		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x22FEB84", Offset = "0x22FEB84", VA = "0x22FEB84")]
		public EventTypeAutoPopupWindowCtrl()
		{
		}
	}

	[Token(Token = "0x200030B")]
	public class EventTypePartyGameSoloDanceBattleClickSucceed : EventLoggerBase
	{
		[Token(Token = "0x4003455")]
		[FieldOffset(Offset = "0x18")]
		public uint click_count;

		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x22FC1F0", Offset = "0x22FC1F0", VA = "0x22FC1F0")]
		public EventTypePartyGameSoloDanceBattleClickSucceed()
		{
		}
	}

	[Token(Token = "0x200030C")]
	public class EventTypePartyGameSoloDanceInvitationAccept : EventLoggerBase
	{
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x22FC2E8", Offset = "0x22FC2E8", VA = "0x22FC2E8")]
		public EventTypePartyGameSoloDanceInvitationAccept()
		{
		}
	}

	[Token(Token = "0x200030D")]
	public class EventTypePartyGameSoloDanceSendInvitation : EventLoggerBase
	{
		[Token(Token = "0x4003456")]
		[FieldOffset(Offset = "0x18")]
		public uint invitation_type;

		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x22FC400", Offset = "0x22FC400", VA = "0x22FC400")]
		public EventTypePartyGameSoloDanceSendInvitation()
		{
		}
	}

	[Token(Token = "0x200030E")]
	public class EventTypePartyGameSoloDanceBattleEnter : EventLoggerBase
	{
		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x22FCB2C", Offset = "0x22FCB2C", VA = "0x22FCB2C")]
		public EventTypePartyGameSoloDanceBattleEnter()
		{
		}
	}

	[Token(Token = "0x200030F")]
	public class EventTypePartyGameSoloDanceBattleFinish : EventLoggerBase
	{
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x22FCC24", Offset = "0x22FCC24", VA = "0x22FCC24")]
		public EventTypePartyGameSoloDanceBattleFinish()
		{
		}
	}

	[Token(Token = "0x2000310")]
	public class EventFPS_RuntimeData
	{
		[Token(Token = "0x2000311")]
		public enum FPSTrackingStep
		{
			[Token(Token = "0x4003461")]
			OnBoard,
			[Token(Token = "0x4003462")]
			InGame,
			[Token(Token = "0x4003463")]
			NB
		}

		[Token(Token = "0x4003457")]
		[FieldOffset(Offset = "0x8")]
		public FPSTrackingStep FPSStep;

		[Token(Token = "0x4003458")]
		[FieldOffset(Offset = "0xC")]
		public float EndTime;

		[Token(Token = "0x4003459")]
		[FieldOffset(Offset = "0x10")]
		public float TotalFPSValueCount;

		[Token(Token = "0x400345A")]
		[FieldOffset(Offset = "0x14")]
		public float TotalFPSValuePowerCount;

		[Token(Token = "0x400345B")]
		[FieldOffset(Offset = "0x18")]
		public uint TotalFPSCount;

		[Token(Token = "0x400345C")]
		[FieldOffset(Offset = "0x1C")]
		public uint TotalFPSB10Count;

		[Token(Token = "0x400345D")]
		[FieldOffset(Offset = "0x20")]
		public uint TotalFPSB20Count;

		[Token(Token = "0x400345E")]
		[FieldOffset(Offset = "0x24")]
		public bool IsRecording;

		[Token(Token = "0x400345F")]
		[FieldOffset(Offset = "0x28")]
		public int JitterCount;

		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x22FE098", Offset = "0x22FE098", VA = "0x22FE098")]
		public EventFPS_RuntimeData()
		{
		}

		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x22E71DC", Offset = "0x22E71DC", VA = "0x22E71DC")]
		public void StartRecording(FPSTrackingStep step, float gameTime, float duration)
		{
		}

		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x22E7830", Offset = "0x22E7830", VA = "0x22E7830")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x22E77A4", Offset = "0x22E77A4", VA = "0x22E77A4")]
		public bool IsExpired(float gameTime)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000312")]
	public class EventGameLag_RuntimeData
	{
		[Token(Token = "0x4003464")]
		[FieldOffset(Offset = "0x8")]
		public float TotalLagTime;

		[Token(Token = "0x4003465")]
		[FieldOffset(Offset = "0xC")]
		public int TotalLagFrameCount;

		[Token(Token = "0x4003466")]
		[FieldOffset(Offset = "0x10")]
		public float MatchTime;

		[Token(Token = "0x4003467")]
		[FieldOffset(Offset = "0x14")]
		public int FrameCount;

		[Token(Token = "0x4003468")]
		[FieldOffset(Offset = "0x18")]
		public bool isStart;

		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x22FE0B0", Offset = "0x22FE0B0", VA = "0x22FE0B0")]
		public EventGameLag_RuntimeData()
		{
		}

		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x22E8E44", Offset = "0x22E8E44", VA = "0x22E8E44")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2000313")]
	public class EventGameMemory_RuntimeData
	{
		[Token(Token = "0x4003469")]
		[FieldOffset(Offset = "0x8")]
		public int Enter_PVP_Memory;

		[Token(Token = "0x400346A")]
		[FieldOffset(Offset = "0xC")]
		public int Leave_PVP_Memory;

		[Token(Token = "0x400346B")]
		[FieldOffset(Offset = "0x10")]
		public int Enter_PVP_AvailMemory;

		[Token(Token = "0x400346C")]
		[FieldOffset(Offset = "0x14")]
		public int Leave_PVP_AvailMemory;

		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x22FE0A8", Offset = "0x22FE0A8", VA = "0x22FE0A8")]
		public EventGameMemory_RuntimeData()
		{
		}

		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x22E7F34", Offset = "0x22E7F34", VA = "0x22E7F34")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2000314")]
	public class EventGameLag : EventLoggerBase
	{
		[Token(Token = "0x400346D")]
		[FieldOffset(Offset = "0x18")]
		public int frame_count;

		[Token(Token = "0x400346E")]
		[FieldOffset(Offset = "0x1C")]
		public float match_time;

		[Token(Token = "0x400346F")]
		[FieldOffset(Offset = "0x20")]
		public float lag_time;

		[Token(Token = "0x4003470")]
		[FieldOffset(Offset = "0x24")]
		public int lag_count;

		[Token(Token = "0x4003471")]
		[FieldOffset(Offset = "0x28")]
		public int quality;

		[Token(Token = "0x4003472")]
		[FieldOffset(Offset = "0x2C")]
		public uint map_id;

		[Token(Token = "0x4003473")]
		[FieldOffset(Offset = "0x30")]
		public uint game_mode;

		[Token(Token = "0x4003474")]
		[FieldOffset(Offset = "0x34")]
		public uint group_mode;

		[Token(Token = "0x4003475")]
		[FieldOffset(Offset = "0x38")]
		public uint match_mode;

		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x22E8E3C", Offset = "0x22E8E3C", VA = "0x22E8E3C")]
		public EventGameLag()
		{
		}
	}

	[Token(Token = "0x2000315")]
	public class EventSplashInfo : EventLoggerBase
	{
		[Token(Token = "0x4003476")]
		[FieldOffset(Offset = "0x18")]
		public float currenct_time;

		[Token(Token = "0x4003477")]
		[FieldOffset(Offset = "0x1C")]
		public uint splash_id;

		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x22FEB74", Offset = "0x22FEB74", VA = "0x22FEB74")]
		public EventSplashInfo()
		{
		}
	}

	[Token(Token = "0x2000316")]
	public class EventBillboardInfo : EventLoggerBase
	{
		[Token(Token = "0x4003478")]
		[FieldOffset(Offset = "0x18")]
		public float currenct_time;

		[Token(Token = "0x4003479")]
		[FieldOffset(Offset = "0x1C")]
		public uint announcement_id;

		[Token(Token = "0x400347A")]
		[FieldOffset(Offset = "0x20")]
		public uint activity_id;

		[Token(Token = "0x400347B")]
		[FieldOffset(Offset = "0x24")]
		public string url;

		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x22E9A58", Offset = "0x22E9A58", VA = "0x22E9A58")]
		public EventBillboardInfo()
		{
		}
	}

	[Token(Token = "0x2000317")]
	public class EventDisconnectFromNetwork : EventLoggerBase
	{
		[Token(Token = "0x400347C")]
		[FieldOffset(Offset = "0x18")]
		public string system_software;

		[Token(Token = "0x400347D")]
		[FieldOffset(Offset = "0x1C")]
		public string system_hardware;

		[Token(Token = "0x400347E")]
		[FieldOffset(Offset = "0x20")]
		public int screen_width;

		[Token(Token = "0x400347F")]
		[FieldOffset(Offset = "0x24")]
		public int screen_hight;

		[Token(Token = "0x4003480")]
		[FieldOffset(Offset = "0x28")]
		public string dpi;

		[Token(Token = "0x4003481")]
		[FieldOffset(Offset = "0x2C")]
		public string cpu_hardware;

		[Token(Token = "0x4003482")]
		[FieldOffset(Offset = "0x30")]
		public int memory;

		[Token(Token = "0x4003483")]
		[FieldOffset(Offset = "0x34")]
		public string gl_render;

		[Token(Token = "0x4003484")]
		[FieldOffset(Offset = "0x38")]
		public string gl_version;

		[Token(Token = "0x4003485")]
		[FieldOffset(Offset = "0x3C")]
		public string network;

		[Token(Token = "0x4003486")]
		[FieldOffset(Offset = "0x40")]
		public int disconnection_type;

		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x22E9FBC", Offset = "0x22E9FBC", VA = "0x22E9FBC")]
		public EventDisconnectFromNetwork()
		{
		}
	}

	[Token(Token = "0x2000318")]
	public enum EventShareAction
	{
		[Token(Token = "0x4003488")]
		OpenUI = 1
	}

	[Token(Token = "0x2000319")]
	public class EventShare : EventLoggerBase
	{
		[Token(Token = "0x4003489")]
		[FieldOffset(Offset = "0x18")]
		public int action;

		[Token(Token = "0x400348A")]
		[FieldOffset(Offset = "0x1C")]
		public bool share_out;

		[Token(Token = "0x400348B")]
		[FieldOffset(Offset = "0x20")]
		public int platform;

		[Token(Token = "0x400348C")]
		[FieldOffset(Offset = "0x24")]
		public int page_id;

		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x22FEB5C", Offset = "0x22FEB5C", VA = "0x22FEB5C")]
		public EventShare()
		{
		}
	}

	[Token(Token = "0x200031A")]
	public class EventShareLinkReturn : EventLoggerBase
	{
		[Token(Token = "0x400348D")]
		[FieldOffset(Offset = "0x18")]
		public string return_from_url;

		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x22EB878", Offset = "0x22EB878", VA = "0x22EB878")]
		public EventShareLinkReturn()
		{
		}
	}

	[Token(Token = "0x200031B")]
	public class EventGachaNotifyState : EventLoggerBase
	{
		[Token(Token = "0x400348E")]
		[FieldOffset(Offset = "0x18")]
		public bool state;

		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x22FEA4C", Offset = "0x22FEA4C", VA = "0x22FEA4C")]
		public EventGachaNotifyState()
		{
		}
	}

	[Token(Token = "0x200031C")]
	public class EventIAPResult : EventLoggerBase
	{
		[Token(Token = "0x400348F")]
		[FieldOffset(Offset = "0x18")]
		public int error_code;

		[Token(Token = "0x4003490")]
		[FieldOffset(Offset = "0x1C")]
		public string error_message;

		[Token(Token = "0x4003491")]
		[FieldOffset(Offset = "0x20")]
		public string item_identifier;

		[Token(Token = "0x4003492")]
		[FieldOffset(Offset = "0x24")]
		public bool is_first_topup;

		[Token(Token = "0x4003493")]
		[FieldOffset(Offset = "0x28")]
		public uint ui_from;

		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x22EB408", Offset = "0x22EB408", VA = "0x22EB408")]
		public EventIAPResult()
		{
		}
	}

	[Token(Token = "0x200031D")]
	public class EventScanIAPResult : EventLoggerBase
	{
		[Token(Token = "0x4003494")]
		[FieldOffset(Offset = "0x18")]
		public string results;

		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x22EB68C", Offset = "0x22EB68C", VA = "0x22EB68C")]
		public EventScanIAPResult()
		{
		}
	}

	[Token(Token = "0x200031E")]
	public class EventIAPRebateResult : EventLoggerBase
	{
		[Token(Token = "0x4003495")]
		[FieldOffset(Offset = "0x18")]
		public int rebate_id;

		[Token(Token = "0x4003496")]
		[FieldOffset(Offset = "0x1C")]
		public int remaining_days;

		[Token(Token = "0x4003497")]
		[FieldOffset(Offset = "0x20")]
		public int error_code;

		[Token(Token = "0x4003498")]
		[FieldOffset(Offset = "0x24")]
		public string error_message;

		[Token(Token = "0x4003499")]
		[FieldOffset(Offset = "0x28")]
		public uint ui_from;

		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x22EBB4C", Offset = "0x22EBB4C", VA = "0x22EBB4C")]
		public EventIAPRebateResult()
		{
		}
	}

	[Token(Token = "0x200031F")]
	public class EventRedeemRebateResult : EventLoggerBase
	{
		[Token(Token = "0x400349A")]
		[FieldOffset(Offset = "0x18")]
		public int rebate_id;

		[Token(Token = "0x400349B")]
		[FieldOffset(Offset = "0x1C")]
		public int remaining_days;

		[Token(Token = "0x400349C")]
		[FieldOffset(Offset = "0x20")]
		public int redeem_amount;

		[Token(Token = "0x400349D")]
		[FieldOffset(Offset = "0x24")]
		public int error_code;

		[Token(Token = "0x400349E")]
		[FieldOffset(Offset = "0x28")]
		public string error_message;

		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x22EBE44", Offset = "0x22EBE44", VA = "0x22EBE44")]
		public EventRedeemRebateResult()
		{
		}
	}

	[Token(Token = "0x2000320")]
	public class EventErrorInHTTP : EventLoggerBase
	{
		[Token(Token = "0x400349F")]
		[FieldOffset(Offset = "0x18")]
		public string system_software;

		[Token(Token = "0x40034A0")]
		[FieldOffset(Offset = "0x1C")]
		public string system_hardware;

		[Token(Token = "0x40034A1")]
		[FieldOffset(Offset = "0x20")]
		public string network;

		[Token(Token = "0x40034A2")]
		[FieldOffset(Offset = "0x24")]
		public string url;

		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x22FEA44", Offset = "0x22FEA44", VA = "0x22FEA44")]
		public EventErrorInHTTP()
		{
		}
	}

	[Token(Token = "0x2000321")]
	public class EventSkyDivingStates : EventLoggerBase
	{
		[Token(Token = "0x40034A3")]
		[FieldOffset(Offset = "0x18")]
		public int switch_mode_times;

		[Token(Token = "0x40034A4")]
		[FieldOffset(Offset = "0x1C")]
		public uint surfing_duration;

		[Token(Token = "0x40034A5")]
		[FieldOffset(Offset = "0x20")]
		public uint diving_duration;

		[Token(Token = "0x40034A6")]
		[FieldOffset(Offset = "0x24")]
		public uint duration_before_parachuting;

		[Token(Token = "0x40034A7")]
		[FieldOffset(Offset = "0x28")]
		public uint game_mode;

		[Token(Token = "0x40034A8")]
		[FieldOffset(Offset = "0x2C")]
		public uint map_id;

		[Token(Token = "0x40034A9")]
		[FieldOffset(Offset = "0x30")]
		public ulong match_id;

		[Token(Token = "0x40034AA")]
		[FieldOffset(Offset = "0x38")]
		public uint sliding_count;

		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x22FEB6C", Offset = "0x22FEB6C", VA = "0x22FEB6C")]
		public EventSkyDivingStates()
		{
		}
	}

	[Token(Token = "0x2000322")]
	public class EventClimbLog : EventLoggerBase
	{
		[Token(Token = "0x40034AB")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x40034AC")]
		[FieldOffset(Offset = "0x20")]
		public uint map_id;

		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x24")]
		public uint game_mode;

		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0x28")]
		public float trigger_pos_x;

		[Token(Token = "0x40034AF")]
		[FieldOffset(Offset = "0x2C")]
		public float trigger_pos_y;

		[Token(Token = "0x40034B0")]
		[FieldOffset(Offset = "0x30")]
		public float trigger_pos_z;

		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x34")]
		public string trigger_tag;

		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x22FEA3C", Offset = "0x22FEA3C", VA = "0x22FEA3C")]
		public EventClimbLog()
		{
		}
	}

	[Token(Token = "0x2000323")]
	public class EventOpenGachaEntrance : EventLoggerBase
	{
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x22EDD08", Offset = "0x22EDD08", VA = "0x22EDD08")]
		public EventOpenGachaEntrance()
		{
		}
	}

	[Token(Token = "0x2000324")]
	public class EventOpenRewardPoolCount : EventLoggerBase
	{
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x22EDF48", Offset = "0x22EDF48", VA = "0x22EDF48")]
		public EventOpenRewardPoolCount()
		{
		}
	}

	[Token(Token = "0x2000325")]
	public class EventElitePassEntry : EventLoggerBase
	{
		[Token(Token = "0x40034B2")]
		[FieldOffset(Offset = "0x18")]
		public uint ep_main_entry_count;

		[Token(Token = "0x40034B3")]
		[FieldOffset(Offset = "0x1C")]
		public uint ep_challenge_entry_count;

		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x22FE0C0", Offset = "0x22FE0C0", VA = "0x22FE0C0")]
		public EventElitePassEntry()
		{
		}
	}

	[Token(Token = "0x2000326")]
	public class EventGiftReceive : EventLoggerBase
	{
		[Token(Token = "0x40034B4")]
		[FieldOffset(Offset = "0x18")]
		public string current_time;

		[Token(Token = "0x40034B5")]
		[FieldOffset(Offset = "0x1C")]
		public uint item_id;

		[Token(Token = "0x40034B6")]
		[FieldOffset(Offset = "0x20")]
		public uint expire_time;

		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x22EE2FC", Offset = "0x22EE2FC", VA = "0x22EE2FC")]
		public EventGiftReceive()
		{
		}
	}

	[Token(Token = "0x2000327")]
	public class EventChat : EventLoggerBase
	{
		[Token(Token = "0x40034B7")]
		[FieldOffset(Offset = "0x18")]
		public ulong group_chan_id;

		[Token(Token = "0x40034B8")]
		[FieldOffset(Offset = "0x20")]
		public uint group_chat_num;

		[Token(Token = "0x40034B9")]
		[FieldOffset(Offset = "0x28")]
		public ulong clan_chan_id;

		[Token(Token = "0x40034BA")]
		[FieldOffset(Offset = "0x30")]
		public uint clan_chat_num;

		[Token(Token = "0x40034BB")]
		[FieldOffset(Offset = "0x34")]
		public uint whisper_chat_num;

		[Token(Token = "0x40034BC")]
		[FieldOffset(Offset = "0x38")]
		public ulong room_chan_id;

		[Token(Token = "0x40034BD")]
		[FieldOffset(Offset = "0x40")]
		public uint room_chat_num;

		[Token(Token = "0x40034BE")]
		[FieldOffset(Offset = "0x44")]
		public uint use_sticker_times;

		[Token(Token = "0x40034BF")]
		[FieldOffset(Offset = "0x48")]
		public ulong world_chan_id;

		[Token(Token = "0x40034C0")]
		[FieldOffset(Offset = "0x50")]
		public uint world_chat_num;

		[Token(Token = "0x40034C1")]
		[FieldOffset(Offset = "0x58")]
		public ulong mentor_chan_id;

		[Token(Token = "0x40034C2")]
		[FieldOffset(Offset = "0x60")]
		public uint mentor_chat_num;

		[Token(Token = "0x40034C3")]
		[FieldOffset(Offset = "0x64")]
		public uint block_list_size;

		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x22FEA24", Offset = "0x22FEA24", VA = "0x22FEA24")]
		public EventChat()
		{
		}
	}

	[Token(Token = "0x2000328")]
	public class EventTypeClientSettingChange : EventLoggerBase
	{
		[Token(Token = "0x40034C4")]
		[FieldOffset(Offset = "0x18")]
		public int is_max;

		[Token(Token = "0x40034C5")]
		[FieldOffset(Offset = "0x1C")]
		public string cur_general_sensitivity;

		[Token(Token = "0x40034C6")]
		[FieldOffset(Offset = "0x20")]
		public string pre_general_sensitivity;

		[Token(Token = "0x40034C7")]
		[FieldOffset(Offset = "0x24")]
		public string cur_free_look_sensitivity;

		[Token(Token = "0x40034C8")]
		[FieldOffset(Offset = "0x28")]
		public string pre_free_look_sensitivity;

		[Token(Token = "0x40034C9")]
		[FieldOffset(Offset = "0x2C")]
		public string cur_music;

		[Token(Token = "0x40034CA")]
		[FieldOffset(Offset = "0x30")]
		public string pre_music;

		[Token(Token = "0x40034CB")]
		[FieldOffset(Offset = "0x34")]
		public string cur_sound_effects;

		[Token(Token = "0x40034CC")]
		[FieldOffset(Offset = "0x38")]
		public string pre_sound_effects;

		[Token(Token = "0x40034CD")]
		[FieldOffset(Offset = "0x3C")]
		public string cur_voice;

		[Token(Token = "0x40034CE")]
		[FieldOffset(Offset = "0x40")]
		public string pre_voice;

		[Token(Token = "0x40034CF")]
		[FieldOffset(Offset = "0x44")]
		public string cur_graphics;

		[Token(Token = "0x40034D0")]
		[FieldOffset(Offset = "0x48")]
		public string pre_graphics;

		[Token(Token = "0x40034D1")]
		[FieldOffset(Offset = "0x4C")]
		public int cur_high_res;

		[Token(Token = "0x40034D2")]
		[FieldOffset(Offset = "0x50")]
		public int pre_high_res;

		[Token(Token = "0x40034D3")]
		[FieldOffset(Offset = "0x54")]
		public int cur_high_fps;

		[Token(Token = "0x40034D4")]
		[FieldOffset(Offset = "0x58")]
		public int pre_high_fps;

		[Token(Token = "0x40034D5")]
		[FieldOffset(Offset = "0x5C")]
		public int cur_shadow;

		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x60")]
		public int pre_shadow;

		[Token(Token = "0x40034D7")]
		[FieldOffset(Offset = "0x64")]
		public int cur_free_look;

		[Token(Token = "0x40034D8")]
		[FieldOffset(Offset = "0x68")]
		public int pre_free_look;

		[Token(Token = "0x40034D9")]
		[FieldOffset(Offset = "0x6C")]
		public int cur_free_look_parachute;

		[Token(Token = "0x40034DA")]
		[FieldOffset(Offset = "0x70")]
		public int pre_free_look_parachute;

		[Token(Token = "0x40034DB")]
		[FieldOffset(Offset = "0x74")]
		public int pre_free_look_dash;

		[Token(Token = "0x40034DC")]
		[FieldOffset(Offset = "0x78")]
		public int cur_free_look_dash;

		[Token(Token = "0x40034DD")]
		[FieldOffset(Offset = "0x7C")]
		public int pre_free_look_drive;

		[Token(Token = "0x40034DE")]
		[FieldOffset(Offset = "0x80")]
		public int cur_free_look_drive;

		[Token(Token = "0x40034DF")]
		[FieldOffset(Offset = "0x84")]
		public int cur_hitmarker;

		[Token(Token = "0x40034E0")]
		[FieldOffset(Offset = "0x88")]
		public int pre_hitmarker;

		[Token(Token = "0x40034E1")]
		[FieldOffset(Offset = "0x8C")]
		public int cur_team_reserve;

		[Token(Token = "0x40034E2")]
		[FieldOffset(Offset = "0x90")]
		public int pre_team_reserve;

		[Token(Token = "0x40034E3")]
		[FieldOffset(Offset = "0x94")]
		public int cur_team_block;

		[Token(Token = "0x40034E4")]
		[FieldOffset(Offset = "0x98")]
		public int pre_team_block;

		[Token(Token = "0x40034E5")]
		[FieldOffset(Offset = "0x9C")]
		public int cur_run;

		[Token(Token = "0x40034E6")]
		[FieldOffset(Offset = "0xA0")]
		public int pre_run;

		[Token(Token = "0x40034E7")]
		[FieldOffset(Offset = "0xA4")]
		public int cur_grenade_slot;

		[Token(Token = "0x40034E8")]
		[FieldOffset(Offset = "0xA8")]
		public int pre_grenade_slot;

		[Token(Token = "0x40034E9")]
		[FieldOffset(Offset = "0xAC")]
		public int cur_chatbubble;

		[Token(Token = "0x40034EA")]
		[FieldOffset(Offset = "0xB0")]
		public int pre_chatbubble;

		[Token(Token = "0x40034EB")]
		[FieldOffset(Offset = "0xB4")]
		public int pre_phone_vibration;

		[Token(Token = "0x40034EC")]
		[FieldOffset(Offset = "0xB8")]
		public int cur_phone_vibration;

		[Token(Token = "0x40034ED")]
		[FieldOffset(Offset = "0xBC")]
		public int pre_external_sound_vibration;

		[Token(Token = "0x40034EE")]
		[FieldOffset(Offset = "0xC0")]
		public int cur_external_sound_vibration;

		[Token(Token = "0x40034EF")]
		[FieldOffset(Offset = "0xC4")]
		public int pre_character_vibration;

		[Token(Token = "0x40034F0")]
		[FieldOffset(Offset = "0xC8")]
		public int cur_character_vibration;

		[Token(Token = "0x40034F1")]
		[FieldOffset(Offset = "0xCC")]
		public int pre_weapon_vibration;

		[Token(Token = "0x40034F2")]
		[FieldOffset(Offset = "0xD0")]
		public int cur_weapon_vibration;

		[Token(Token = "0x40034F3")]
		[FieldOffset(Offset = "0xD4")]
		public int pre_vehicle_vibration;

		[Token(Token = "0x40034F4")]
		[FieldOffset(Offset = "0xD8")]
		public int cur_vehicle_vibration;

		[Token(Token = "0x40034F5")]
		[FieldOffset(Offset = "0xDC")]
		public int pre_push_friend_request;

		[Token(Token = "0x40034F6")]
		[FieldOffset(Offset = "0xE0")]
		public int cur_push_friend_request;

		[Token(Token = "0x40034F7")]
		[FieldOffset(Offset = "0xE4")]
		public int pre_editor_friend_message;

		[Token(Token = "0x40034F8")]
		[FieldOffset(Offset = "0xE8")]
		public int cur_editor_friend_message;

		[Token(Token = "0x40034F9")]
		[FieldOffset(Offset = "0xEC")]
		public int pre_warning_foot;

		[Token(Token = "0x40034FA")]
		[FieldOffset(Offset = "0xF0")]
		public int cur_warning_foot;

		[Token(Token = "0x40034FB")]
		[FieldOffset(Offset = "0xF4")]
		public int pre_warning_gun;

		[Token(Token = "0x40034FC")]
		[FieldOffset(Offset = "0xF8")]
		public int cur_warning_gun;

		[Token(Token = "0x40034FD")]
		[FieldOffset(Offset = "0xFC")]
		public int pre_gloo_wall_smart_release;

		[Token(Token = "0x40034FE")]
		[FieldOffset(Offset = "0x100")]
		public int cur_gloo_wall_smart_release;

		[Token(Token = "0x40034FF")]
		[FieldOffset(Offset = "0x104")]
		public int cur_character_voice;

		[Token(Token = "0x4003500")]
		[FieldOffset(Offset = "0x108")]
		public int pre_character_voice;

		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x22FE0F0", Offset = "0x22FE0F0", VA = "0x22FE0F0")]
		public EventTypeClientSettingChange()
		{
		}

		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x22F8714", Offset = "0x22F8714", VA = "0x22F8714")]
		public bool IsChange()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000329")]
	public class EventNavigate : EventLoggerBase
	{
		[Token(Token = "0x4003501")]
		[FieldOffset(Offset = "0x18")]
		public List<EventNavigateClick> clicks;

		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x22F28BC", Offset = "0x22F28BC", VA = "0x22F28BC")]
		public EventNavigate()
		{
		}
	}

	[Token(Token = "0x200032A")]
	public class EventNavigateClick
	{
		[Token(Token = "0x4003502")]
		[FieldOffset(Offset = "0x8")]
		public string from;

		[Token(Token = "0x4003503")]
		[FieldOffset(Offset = "0xC")]
		public string to;

		[Token(Token = "0x4003504")]
		[FieldOffset(Offset = "0x10")]
		public int cnt;

		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x22F2948", Offset = "0x22F2948", VA = "0x22F2948")]
		public EventNavigateClick()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200032B")]
	public class EventClick : EventLoggerBase
	{
		[Token(Token = "0x4003505")]
		[FieldOffset(Offset = "0x18")]
		public List<ClickEntry> clicks;

		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x22F2D88", Offset = "0x22F2D88", VA = "0x22F2D88")]
		public EventClick()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200032C")]
	public class ClickEntry
	{
		[Token(Token = "0x4003506")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0xC")]
		public uint cnt;

		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x22F2D90", Offset = "0x22F2D90", VA = "0x22F2D90")]
		public ClickEntry()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200032D")]
	public class EventLiveZoneClickCount : EventLoggerBase
	{
		[Token(Token = "0x4003508")]
		[FieldOffset(Offset = "0x18")]
		public List<LiveZoneClickInfo> zone_click_result;

		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x22FEA6C", Offset = "0x22FEA6C", VA = "0x22FEA6C")]
		public EventLiveZoneClickCount()
		{
		}
	}

	[Token(Token = "0x200032E")]
	public class LiveZoneClickInfo
	{
		[Token(Token = "0x4003509")]
		[FieldOffset(Offset = "0x8")]
		public ulong streamer_id;

		[Token(Token = "0x400350A")]
		[FieldOffset(Offset = "0x10")]
		public uint click_count;

		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x22FF020", Offset = "0x22FF020", VA = "0x22FF020")]
		public LiveZoneClickInfo(ulong id, uint count)
		{
		}
	}

	[Token(Token = "0x200032F")]
	public class EventIAPBundlePurchase : EventLoggerBase
	{
		[Token(Token = "0x400350B")]
		[FieldOffset(Offset = "0x18")]
		public string current_time;

		[Token(Token = "0x400350C")]
		[FieldOffset(Offset = "0x1C")]
		public int store_id;

		[Token(Token = "0x400350D")]
		[FieldOffset(Offset = "0x20")]
		public int bundle_id;

		[Token(Token = "0x400350E")]
		[FieldOffset(Offset = "0x24")]
		public float price_usd;

		[Token(Token = "0x400350F")]
		[FieldOffset(Offset = "0x28")]
		public int discount;

		[Token(Token = "0x4003510")]
		[FieldOffset(Offset = "0x2C")]
		public int rebate_id;

		[Token(Token = "0x4003511")]
		[FieldOffset(Offset = "0x30")]
		public string product_identifier;

		[Token(Token = "0x4003512")]
		[FieldOffset(Offset = "0x34")]
		public uint ui_from;

		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x22EE64C", Offset = "0x22EE64C", VA = "0x22EE64C")]
		public EventIAPBundlePurchase()
		{
		}
	}

	[Token(Token = "0x2000330")]
	public class EventPaymentBundlePurchase : EventLoggerBase
	{
		[Token(Token = "0x4003513")]
		[FieldOffset(Offset = "0x18")]
		public string current_time;

		[Token(Token = "0x4003514")]
		[FieldOffset(Offset = "0x1C")]
		public int id;

		[Token(Token = "0x4003515")]
		[FieldOffset(Offset = "0x20")]
		public int discount;

		[Token(Token = "0x4003516")]
		[FieldOffset(Offset = "0x24")]
		public int rebate_id;

		[Token(Token = "0x4003517")]
		[FieldOffset(Offset = "0x28")]
		public string product_identifier;

		[Token(Token = "0x4003518")]
		[FieldOffset(Offset = "0x2C")]
		public uint ui_from;

		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x22FEB14", Offset = "0x22FEB14", VA = "0x22FEB14")]
		public EventPaymentBundlePurchase()
		{
		}
	}

	[Token(Token = "0x2000331")]
	public class EventBroadCastTypeCnt : EventLoggerBase
	{
		[Token(Token = "0x4003519")]
		[FieldOffset(Offset = "0x18")]
		public List<EventBroadCastEntry> entries;

		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x22F5AFC", Offset = "0x22F5AFC", VA = "0x22F5AFC")]
		public EventBroadCastTypeCnt()
		{
		}
	}

	[Token(Token = "0x2000332")]
	public class EventBroadCastEntry
	{
		[Token(Token = "0x400351A")]
		[FieldOffset(Offset = "0x8")]
		public EventBroadCastType type;

		[Token(Token = "0x400351B")]
		[FieldOffset(Offset = "0xC")]
		public int cnt;

		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x22F5B04", Offset = "0x22F5B04", VA = "0x22F5B04")]
		public EventBroadCastEntry()
		{
		}
	}

	[Token(Token = "0x2000333")]
	public class EventPopularList
	{
		[Token(Token = "0x400351C")]
		[FieldOffset(Offset = "0x8")]
		public string workshop_code;

		[Token(Token = "0x400351D")]
		[FieldOffset(Offset = "0xC")]
		public int cnt;

		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x22F46C4", Offset = "0x22F46C4", VA = "0x22F46C4")]
		public EventPopularList()
		{
		}
	}

	[Token(Token = "0x2000334")]
	public class EventWeekList
	{
		[Token(Token = "0x400351E")]
		[FieldOffset(Offset = "0x8")]
		public string workshop_code;

		[Token(Token = "0x400351F")]
		[FieldOffset(Offset = "0xC")]
		public int cnt;

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x22F4ED8", Offset = "0x22F4ED8", VA = "0x22F4ED8")]
		public EventWeekList()
		{
		}
	}

	[Token(Token = "0x2000335")]
	public class RecommendItemLog
	{
		[Token(Token = "0x4003520")]
		[FieldOffset(Offset = "0x8")]
		public string workshop_code;

		[Token(Token = "0x4003521")]
		[FieldOffset(Offset = "0xC")]
		public int cnt;

		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x22F5774", Offset = "0x22F5774", VA = "0x22F5774")]
		public RecommendItemLog()
		{
		}
	}

	[Token(Token = "0x2000336")]
	public class EventTypeClickWorkshopMapExposed : EventLoggerBase
	{
		[Token(Token = "0x4003522")]
		[FieldOffset(Offset = "0x18")]
		public List<EventPopularList> popular_list;

		[Token(Token = "0x4003523")]
		[FieldOffset(Offset = "0x1C")]
		public List<EventWeekList> week_list;

		[Token(Token = "0x4003524")]
		[FieldOffset(Offset = "0x20")]
		public List<RecommendItemLog> recommend_list;

		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x22F46BC", Offset = "0x22F46BC", VA = "0x22F46BC")]
		public EventTypeClickWorkshopMapExposed()
		{
		}
	}

	[Token(Token = "0x2000337")]
	public class EventElitePassSubscribe : EventLoggerBase
	{
		[Token(Token = "0x4003525")]
		[FieldOffset(Offset = "0x18")]
		public bool result;

		[Token(Token = "0x4003526")]
		[FieldOffset(Offset = "0x1C")]
		public int errorCode;

		[Token(Token = "0x4003527")]
		[FieldOffset(Offset = "0x20")]
		public string price;

		[Token(Token = "0x4003528")]
		[FieldOffset(Offset = "0x24")]
		public string product_identifier;

		[Token(Token = "0x4003529")]
		[FieldOffset(Offset = "0x28")]
		public int rebate_id;

		[Token(Token = "0x400352A")]
		[FieldOffset(Offset = "0x2C")]
		public uint ui_from;

		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x22EE8FC", Offset = "0x22EE8FC", VA = "0x22EE8FC")]
		public EventElitePassSubscribe()
		{
		}
	}

	[Token(Token = "0x2000338")]
	public class EventAndroidApplicationDetection : EventLoggerBase
	{
		[Token(Token = "0x400352B")]
		[FieldOffset(Offset = "0x18")]
		public string detection;

		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x22EEBD0", Offset = "0x22EEBD0", VA = "0x22EEBD0")]
		public EventAndroidApplicationDetection()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000339")]
	public class EventNavigationClickCount : EventLoggerBase
	{
		[Token(Token = "0x400352C")]
		[FieldOffset(Offset = "0x18")]
		public uint activity_id;

		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x1C")]
		public uint navigation_clicks;

		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x22FEAF4", Offset = "0x22FEAF4", VA = "0x22FEAF4")]
		public EventNavigationClickCount()
		{
		}
	}

	[Token(Token = "0x200033A")]
	public class EventGotoOthersPersonalShowTimes : EventLoggerBase
	{
		[Token(Token = "0x400352E")]
		[FieldOffset(Offset = "0x18")]
		public uint group_list;

		[Token(Token = "0x400352F")]
		[FieldOffset(Offset = "0x1C")]
		public uint clan_members;

		[Token(Token = "0x4003530")]
		[FieldOffset(Offset = "0x20")]
		public uint friend_list;

		[Token(Token = "0x4003531")]
		[FieldOffset(Offset = "0x24")]
		public uint search_account;

		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0x28")]
		public uint friend_application;

		[Token(Token = "0x4003533")]
		[FieldOffset(Offset = "0x2C")]
		public uint leaderboard;

		[Token(Token = "0x4003534")]
		[FieldOffset(Offset = "0x30")]
		public uint chat;

		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x22FEA54", Offset = "0x22FEA54", VA = "0x22FEA54")]
		public EventGotoOthersPersonalShowTimes()
		{
		}
	}

	[Token(Token = "0x200033B")]
	public class EventVehicleControlMode : EventLoggerBase
	{
		[Token(Token = "0x4003535")]
		[FieldOffset(Offset = "0x18")]
		public uint control_mode;

		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x22FF000", Offset = "0x22FF000", VA = "0x22FF000")]
		public EventVehicleControlMode()
		{
		}
	}

	[Token(Token = "0x200033C")]
	public class EventEnterGame : EventLoggerBase
	{
		[Token(Token = "0x4003536")]
		[FieldOffset(Offset = "0x18")]
		public string system_software;

		[Token(Token = "0x4003537")]
		[FieldOffset(Offset = "0x1C")]
		public string system_hardware;

		[Token(Token = "0x4003538")]
		[FieldOffset(Offset = "0x20")]
		public string dpi;

		[Token(Token = "0x4003539")]
		[FieldOffset(Offset = "0x24")]
		public string cpu_hardware;

		[Token(Token = "0x400353A")]
		[FieldOffset(Offset = "0x28")]
		public int memory;

		[Token(Token = "0x400353B")]
		[FieldOffset(Offset = "0x2C")]
		public string gl_render;

		[Token(Token = "0x400353C")]
		[FieldOffset(Offset = "0x30")]
		public string gl_version;

		[Token(Token = "0x400353D")]
		[FieldOffset(Offset = "0x34")]
		public string device_model;

		[Token(Token = "0x400353E")]
		[FieldOffset(Offset = "0x38")]
		public ulong match_id;

		[Token(Token = "0x400353F")]
		[FieldOffset(Offset = "0x40")]
		public int is_night_mode;

		[Token(Token = "0x4003540")]
		[FieldOffset(Offset = "0x44")]
		public uint tick_count;

		[Token(Token = "0x4003541")]
		[FieldOffset(Offset = "0x48")]
		public uint group_mode;

		[Token(Token = "0x4003542")]
		[FieldOffset(Offset = "0x4C")]
		public uint time_to_wait;

		[Token(Token = "0x4003543")]
		[FieldOffset(Offset = "0x50")]
		public string lib_path;

		[Token(Token = "0x4003544")]
		[FieldOffset(Offset = "0x54")]
		public uint quality;

		[Token(Token = "0x4003545")]
		[FieldOffset(Offset = "0x58")]
		public uint game_mode;

		[Token(Token = "0x4003546")]
		[FieldOffset(Offset = "0x5C")]
		public uint match_mode;

		[Token(Token = "0x4003547")]
		[FieldOffset(Offset = "0x60")]
		public string lib_token;

		[Token(Token = "0x4003548")]
		[FieldOffset(Offset = "0x64")]
		public uint map_id;

		[Token(Token = "0x4003549")]
		[FieldOffset(Offset = "0x68")]
		public uint shadow_option;

		[Token(Token = "0x400354A")]
		[FieldOffset(Offset = "0x6C")]
		public uint loading_time;

		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x22FE100", Offset = "0x22FE100", VA = "0x22FE100")]
		public EventEnterGame()
		{
		}
	}

	[Token(Token = "0x200033D")]
	public class EventLeaveGame : EventLoggerBase
	{
		[Token(Token = "0x400354B")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x400354C")]
		[FieldOffset(Offset = "0x20")]
		public uint tick_count;

		[Token(Token = "0x400354D")]
		[FieldOffset(Offset = "0x24")]
		public string system_software;

		[Token(Token = "0x400354E")]
		[FieldOffset(Offset = "0x28")]
		public string system_hardware;

		[Token(Token = "0x400354F")]
		[FieldOffset(Offset = "0x2C")]
		public int screen_width;

		[Token(Token = "0x4003550")]
		[FieldOffset(Offset = "0x30")]
		public int screen_hight;

		[Token(Token = "0x4003551")]
		[FieldOffset(Offset = "0x34")]
		public string dpi;

		[Token(Token = "0x4003552")]
		[FieldOffset(Offset = "0x38")]
		public string cpu_hardware;

		[Token(Token = "0x4003553")]
		[FieldOffset(Offset = "0x3C")]
		public int memory;

		[Token(Token = "0x4003554")]
		[FieldOffset(Offset = "0x40")]
		public string gl_render;

		[Token(Token = "0x4003555")]
		[FieldOffset(Offset = "0x44")]
		public string gl_version;

		[Token(Token = "0x4003556")]
		[FieldOffset(Offset = "0x48")]
		public string device_model;

		[Token(Token = "0x4003557")]
		[FieldOffset(Offset = "0x4C")]
		public int quality;

		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x50")]
		public uint map_id;

		[Token(Token = "0x4003559")]
		[FieldOffset(Offset = "0x54")]
		public uint game_mode;

		[Token(Token = "0x400355A")]
		[FieldOffset(Offset = "0x58")]
		public uint group_mode;

		[Token(Token = "0x400355B")]
		[FieldOffset(Offset = "0x5C")]
		public uint match_mode;

		[Token(Token = "0x400355C")]
		[FieldOffset(Offset = "0x60")]
		public int fps1;

		[Token(Token = "0x400355D")]
		[FieldOffset(Offset = "0x64")]
		public int step1;

		[Token(Token = "0x400355E")]
		[FieldOffset(Offset = "0x68")]
		public float fps_devi1;

		[Token(Token = "0x400355F")]
		[FieldOffset(Offset = "0x6C")]
		public uint fps_data_total_count1;

		[Token(Token = "0x4003560")]
		[FieldOffset(Offset = "0x70")]
		public uint fps_data_b10_count1;

		[Token(Token = "0x4003561")]
		[FieldOffset(Offset = "0x74")]
		public uint fps_data_b20_count1;

		[Token(Token = "0x4003562")]
		[FieldOffset(Offset = "0x78")]
		public int jitter_count1;

		[Token(Token = "0x4003563")]
		[FieldOffset(Offset = "0x7C")]
		public int fps2;

		[Token(Token = "0x4003564")]
		[FieldOffset(Offset = "0x80")]
		public int step2;

		[Token(Token = "0x4003565")]
		[FieldOffset(Offset = "0x84")]
		public float fps_devi2;

		[Token(Token = "0x4003566")]
		[FieldOffset(Offset = "0x88")]
		public uint fps_data_total_count2;

		[Token(Token = "0x4003567")]
		[FieldOffset(Offset = "0x8C")]
		public uint fps_data_b10_count2;

		[Token(Token = "0x4003568")]
		[FieldOffset(Offset = "0x90")]
		public uint fps_data_b20_count2;

		[Token(Token = "0x4003569")]
		[FieldOffset(Offset = "0x94")]
		public int jitter_count2;

		[Token(Token = "0x400356A")]
		[FieldOffset(Offset = "0x98")]
		public int ping;

		[Token(Token = "0x400356B")]
		[FieldOffset(Offset = "0x9C")]
		public int maxping;

		[Token(Token = "0x400356C")]
		[FieldOffset(Offset = "0xA0")]
		public int ping_total;

		[Token(Token = "0x400356D")]
		[FieldOffset(Offset = "0xA4")]
		public int ping_b500;

		[Token(Token = "0x400356E")]
		[FieldOffset(Offset = "0xA8")]
		public int ping_a500;

		[Token(Token = "0x400356F")]
		[FieldOffset(Offset = "0xAC")]
		public int ping100200;

		[Token(Token = "0x4003570")]
		[FieldOffset(Offset = "0xB0")]
		public int ping200300;

		[Token(Token = "0x4003571")]
		[FieldOffset(Offset = "0xB4")]
		public int ping300400;

		[Token(Token = "0x4003572")]
		[FieldOffset(Offset = "0xB8")]
		public int ping400500;

		[Token(Token = "0x4003573")]
		[FieldOffset(Offset = "0xBC")]
		public string gameserver_ip;

		[Token(Token = "0x4003574")]
		[FieldOffset(Offset = "0xC0")]
		public string phone_carrier;

		[Token(Token = "0x4003575")]
		[FieldOffset(Offset = "0xC4")]
		public string country;

		[Token(Token = "0x4003576")]
		[FieldOffset(Offset = "0xC8")]
		public ulong packet_sent;

		[Token(Token = "0x4003577")]
		[FieldOffset(Offset = "0xD0")]
		public ulong rudp_packet_sent;

		[Token(Token = "0x4003578")]
		[FieldOffset(Offset = "0xD8")]
		public ulong rudp_packet_resent;

		[Token(Token = "0x4003579")]
		[FieldOffset(Offset = "0xE0")]
		public int enter_pvp_memory;

		[Token(Token = "0x400357A")]
		[FieldOffset(Offset = "0xE4")]
		public int leave_pvp_memory;

		[Token(Token = "0x400357B")]
		[FieldOffset(Offset = "0xE8")]
		public int enter_pvp_avail_memory;

		[Token(Token = "0x400357C")]
		[FieldOffset(Offset = "0xEC")]
		public int leave_pvp_avail_memory;

		[Token(Token = "0x400357D")]
		[FieldOffset(Offset = "0xF0")]
		public int low_memory_threshold;

		[Token(Token = "0x400357E")]
		[FieldOffset(Offset = "0xF4")]
		public int max_avail_memory;

		[Token(Token = "0x400357F")]
		[FieldOffset(Offset = "0xF8")]
		public int min_avail_memory;

		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0xFC")]
		public int unload_unused_count;

		[Token(Token = "0x4003581")]
		[FieldOffset(Offset = "0x100")]
		public float enter_battery;

		[Token(Token = "0x4003582")]
		[FieldOffset(Offset = "0x104")]
		public float leave_battery;

		[Token(Token = "0x4003583")]
		[FieldOffset(Offset = "0x108")]
		public bool is_charge;

		[Token(Token = "0x4003584")]
		[FieldOffset(Offset = "0x10C")]
		public uint resource_load_count;

		[Token(Token = "0x4003585")]
		[FieldOffset(Offset = "0x110")]
		public uint game_time;

		[Token(Token = "0x4003586")]
		[FieldOffset(Offset = "0x114")]
		public int global_fps;

		[Token(Token = "0x4003587")]
		[FieldOffset(Offset = "0x118")]
		public int trigger_near_count;

		[Token(Token = "0x4003588")]
		[FieldOffset(Offset = "0x11C")]
		public int trigger_far_count;

		[Token(Token = "0x4003589")]
		[FieldOffset(Offset = "0x120")]
		public List<uint> trigger_id_list;

		[Token(Token = "0x400358A")]
		[FieldOffset(Offset = "0x124")]
		public List<string> scene_object_pin_list;

		[Token(Token = "0x400358B")]
		[FieldOffset(Offset = "0x128")]
		public int default_pin_count;

		[Token(Token = "0x400358C")]
		[FieldOffset(Offset = "0x12C")]
		public int enemy_pin_count;

		[Token(Token = "0x400358D")]
		[FieldOffset(Offset = "0x130")]
		public int supplies_pin_count;

		[Token(Token = "0x400358E")]
		[FieldOffset(Offset = "0x134")]
		public int pet_id;

		[Token(Token = "0x400358F")]
		[FieldOffset(Offset = "0x138")]
		public uint pet_click_cnt;

		[Token(Token = "0x4003590")]
		[FieldOffset(Offset = "0x13C")]
		public uint shadow_option;

		[Token(Token = "0x4003591")]
		[FieldOffset(Offset = "0x140")]
		public uint loading_time;

		[Token(Token = "0x4003592")]
		[FieldOffset(Offset = "0x144")]
		public uint cpu_type;

		[Token(Token = "0x4003593")]
		[FieldOffset(Offset = "0x148")]
		public bool is_high_framerate;

		[Token(Token = "0x4003594")]
		[FieldOffset(Offset = "0x14C")]
		public uint click_map_cnt;

		[Token(Token = "0x4003595")]
		[FieldOffset(Offset = "0x150")]
		public bool is_emulator;

		[Token(Token = "0x4003596")]
		[FieldOffset(Offset = "0x154")]
		public uint sub_mode;

		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x22F0F04", Offset = "0x22F0F04", VA = "0x22F0F04")]
		public EventLeaveGame()
		{
		}
	}

	[Token(Token = "0x200033E")]
	public class EventBRDeadInfo : EventLoggerBase
	{
		[Token(Token = "0x4003597")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x4003598")]
		[FieldOffset(Offset = "0x20")]
		public int quality;

		[Token(Token = "0x4003599")]
		[FieldOffset(Offset = "0x24")]
		public uint map_id;

		[Token(Token = "0x400359A")]
		[FieldOffset(Offset = "0x28")]
		public uint game_mode;

		[Token(Token = "0x400359B")]
		[FieldOffset(Offset = "0x2C")]
		public uint group_mode;

		[Token(Token = "0x400359C")]
		[FieldOffset(Offset = "0x30")]
		public uint match_mode;

		[Token(Token = "0x400359D")]
		[FieldOffset(Offset = "0x34")]
		public int dead_reason;

		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x22FE128", Offset = "0x22FE128", VA = "0x22FE128")]
		public EventBRDeadInfo()
		{
		}
	}

	[Token(Token = "0x200033F")]
	public class EventHighFPSSwitch : EventLoggerBase
	{
		[Token(Token = "0x400359E")]
		[FieldOffset(Offset = "0x18")]
		public string device_model;

		[Token(Token = "0x400359F")]
		[FieldOffset(Offset = "0x1C")]
		public bool switch_highfps;

		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x22F1050", Offset = "0x22F1050", VA = "0x22F1050")]
		public EventHighFPSSwitch()
		{
		}
	}

	[Token(Token = "0x2000340")]
	public class EventTypeGuideTrigger : EventLoggerBase
	{
		[Token(Token = "0x40035A0")]
		[FieldOffset(Offset = "0x18")]
		public uint guide_id;

		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x22F16D8", Offset = "0x22F16D8", VA = "0x22F16D8")]
		public EventTypeGuideTrigger()
		{
		}
	}

	[Token(Token = "0x2000341")]
	public class EventTypeGuideCloseInfo : EventLoggerBase
	{
		[Token(Token = "0x40035A1")]
		[FieldOffset(Offset = "0x18")]
		public uint guide_id;

		[Token(Token = "0x40035A2")]
		[FieldOffset(Offset = "0x1C")]
		public uint close_type;

		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x22F180C", Offset = "0x22F180C", VA = "0x22F180C")]
		public EventTypeGuideCloseInfo()
		{
		}
	}

	[Token(Token = "0x2000342")]
	public class EventTypeOptionalDownloadInfoList : EventLoggerBase
	{
		[Token(Token = "0x40035A3")]
		[FieldOffset(Offset = "0x18")]
		public List<EventTypeOptionalDownloadInfo> optional_download_info;

		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x22F149C", Offset = "0x22F149C", VA = "0x22F149C")]
		public EventTypeOptionalDownloadInfoList()
		{
		}
	}

	[Token(Token = "0x2000343")]
	public class EventTypeUGCMapDetailsPopup : EventLoggerBase
	{
		[Token(Token = "0x2000344")]
		public class ClickInfo
		{
			[Token(Token = "0x40035A5")]
			[FieldOffset(Offset = "0x8")]
			public uint map_scene;

			[Token(Token = "0x40035A6")]
			[FieldOffset(Offset = "0xC")]
			public string workshop_code;

			[Token(Token = "0x40035A7")]
			[FieldOffset(Offset = "0x10")]
			public ulong author_id;

			[Token(Token = "0x40035A8")]
			[FieldOffset(Offset = "0x18")]
			public uint cnt;

			[Token(Token = "0x6000EBA")]
			[Address(RVA = "0x22F3F10", Offset = "0x22F3F10", VA = "0x22F3F10")]
			public ClickInfo()
			{
			}
		}

		[Token(Token = "0x40035A4")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<ClickInfo> click_infos;

		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x22F3E84", Offset = "0x22F3E84", VA = "0x22F3E84")]
		public EventTypeUGCMapDetailsPopup()
		{
		}
	}

	[Token(Token = "0x2000345")]
	public class EventTypeOptionalDownloadInfo : EventLoggerBase
	{
		[Token(Token = "0x40035A9")]
		[FieldOffset(Offset = "0x18")]
		public string package_name;

		[Token(Token = "0x40035AA")]
		[FieldOffset(Offset = "0x1C")]
		public int download_type;

		[Token(Token = "0x40035AB")]
		[FieldOffset(Offset = "0x20")]
		public bool complete_result;

		[Token(Token = "0x40035AC")]
		[FieldOffset(Offset = "0x24")]
		public string optional_version;

		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x22F14A4", Offset = "0x22F14A4", VA = "0x22F14A4")]
		public EventTypeOptionalDownloadInfo()
		{
		}
	}

	[Token(Token = "0x2000346")]
	public class EventTypeOptionalBundleDownload : EventLoggerBase
	{
		[Token(Token = "0x2000347")]
		public class SingleEvent
		{
			[Token(Token = "0x40035AE")]
			[FieldOffset(Offset = "0x8")]
			public uint bundle_id;

			[Token(Token = "0x40035AF")]
			[FieldOffset(Offset = "0xC")]
			public string package_name;

			[Token(Token = "0x40035B0")]
			[FieldOffset(Offset = "0x10")]
			public uint download_network_status;

			[Token(Token = "0x40035B1")]
			[FieldOffset(Offset = "0x14")]
			public uint[] download_type;

			[Token(Token = "0x40035B2")]
			[FieldOffset(Offset = "0x18")]
			public string complete_result;

			[Token(Token = "0x40035B3")]
			[FieldOffset(Offset = "0x1C")]
			public string optional_version;

			[Token(Token = "0x6000EBD")]
			[Address(RVA = "0x22F1F10", Offset = "0x22F1F10", VA = "0x22F1F10")]
			public SingleEvent()
			{
			}
		}

		[Token(Token = "0x40035AD")]
		[FieldOffset(Offset = "0x18")]
		public List<SingleEvent> bundle_download_info;

		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x22F1F08", Offset = "0x22F1F08", VA = "0x22F1F08")]
		public EventTypeOptionalBundleDownload()
		{
		}
	}

	[Token(Token = "0x2000348")]
	public class EventTypetOptionalBundleDelete : EventLoggerBase
	{
		[Token(Token = "0x40035B4")]
		[FieldOffset(Offset = "0x18")]
		public uint bundle_id;

		[Token(Token = "0x40035B5")]
		[FieldOffset(Offset = "0x1C")]
		public uint[] download_type;

		[Token(Token = "0x40035B6")]
		[FieldOffset(Offset = "0x20")]
		public string optional_version;

		[Token(Token = "0x40035B7")]
		[FieldOffset(Offset = "0x24")]
		public bool delete_recommend;

		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x22F2438", Offset = "0x22F2438", VA = "0x22F2438")]
		public EventTypetOptionalBundleDelete()
		{
		}
	}

	[Token(Token = "0x2000349")]
	public class EventTypeHudSettingChange : EventLoggerBase
	{
		[Token(Token = "0x200034A")]
		public class SimpleHudChange
		{
			[Token(Token = "0x40035B9")]
			[FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x40035BA")]
			[FieldOffset(Offset = "0x10")]
			public double size;

			[Token(Token = "0x40035BB")]
			[FieldOffset(Offset = "0x18")]
			public double pos_x;

			[Token(Token = "0x40035BC")]
			[FieldOffset(Offset = "0x20")]
			public double pos_y;

			[Token(Token = "0x6000EC0")]
			[Address(RVA = "0x22F2294", Offset = "0x22F2294", VA = "0x22F2294")]
			public SimpleHudChange()
			{
			}
		}

		[Token(Token = "0x40035B8")]
		[FieldOffset(Offset = "0x18")]
		public List<SimpleHudChange> hud;

		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x22F228C", Offset = "0x22F228C", VA = "0x22F228C")]
		public EventTypeHudSettingChange()
		{
		}
	}

	[Token(Token = "0x200034B")]
	public class EventClickGetAvatarBtn : EventLoggerBase
	{
		[Token(Token = "0x40035BD")]
		[FieldOffset(Offset = "0x18")]
		public uint avatar_id;

		[Token(Token = "0x40035BE")]
		[FieldOffset(Offset = "0x1C")]
		public uint get_times;

		[Token(Token = "0x40035BF")]
		[FieldOffset(Offset = "0x20")]
		public uint bundle_times;

		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x22F61B8", Offset = "0x22F61B8", VA = "0x22F61B8")]
		public EventClickGetAvatarBtn()
		{
		}
	}

	[Token(Token = "0x200034C")]
	public class EventRewardedVideoLoadLog : EventLoggerBase
	{
		[Token(Token = "0x40035C0")]
		[FieldOffset(Offset = "0x18")]
		public uint success;

		[Token(Token = "0x40035C1")]
		[FieldOffset(Offset = "0x1C")]
		public uint failure;

		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x22FEB4C", Offset = "0x22FEB4C", VA = "0x22FEB4C")]
		public EventRewardedVideoLoadLog()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200034D")]
	public class EventMallTabClickCount : EventLoggerBase
	{
		[Token(Token = "0x40035C2")]
		[FieldOffset(Offset = "0x18")]
		public List<EventMallTabClickInfo> mall_tab_click_result;

		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x22F5E94", Offset = "0x22F5E94", VA = "0x22F5E94")]
		public EventMallTabClickCount()
		{
		}
	}

	[Token(Token = "0x200034E")]
	public class EventVideoWatchTime : EventLoggerBase
	{
		[Token(Token = "0x40035C3")]
		[FieldOffset(Offset = "0x18")]
		public ulong watch_time;

		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x22FF008", Offset = "0x22FF008", VA = "0x22FF008")]
		public EventVideoWatchTime()
		{
		}
	}

	[Token(Token = "0x200034F")]
	public class EventMallTabClickInfo
	{
		[Token(Token = "0x40035C4")]
		[FieldOffset(Offset = "0x8")]
		public uint mall_type;

		[Token(Token = "0x40035C5")]
		[FieldOffset(Offset = "0xC")]
		public string tab_name;

		[Token(Token = "0x40035C6")]
		[FieldOffset(Offset = "0x10")]
		public uint count;

		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x22F5E9C", Offset = "0x22F5E9C", VA = "0x22F5E9C")]
		public EventMallTabClickInfo(uint mallType, string name, uint cnt)
		{
		}
	}

	[Token(Token = "0x2000350")]
	public class EventInstallmentClickCount : EventLoggerBase
	{
		[Token(Token = "0x40035C7")]
		[FieldOffset(Offset = "0x18")]
		public uint mall_clicks;

		[Token(Token = "0x40035C8")]
		[FieldOffset(Offset = "0x1C")]
		public uint inventory_clicks;

		[Token(Token = "0x40035C9")]
		[FieldOffset(Offset = "0x20")]
		public uint tutorial_clicks;

		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x22FEA64", Offset = "0x22FEA64", VA = "0x22FEA64")]
		public EventInstallmentClickCount()
		{
		}
	}

	[Token(Token = "0x2000351")]
	public class EventBackMallCount : EventLoggerBase
	{
		[Token(Token = "0x40035CA")]
		[FieldOffset(Offset = "0x18")]
		public uint back_mall_count;

		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x22F606C", Offset = "0x22F606C", VA = "0x22F606C")]
		public EventBackMallCount()
		{
		}
	}

	[Token(Token = "0x2000352")]
	public class EventMallItemClickCount : EventLoggerBase
	{
		[Token(Token = "0x40035CB")]
		[FieldOffset(Offset = "0x18")]
		public List<EventMallItemClickInfo> clicks;

		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x22FEAAC", Offset = "0x22FEAAC", VA = "0x22FEAAC")]
		public EventMallItemClickCount()
		{
		}
	}

	[Token(Token = "0x2000353")]
	public class EventBooyahClickEquip : EventLoggerBase
	{
		[Token(Token = "0x40035CC")]
		[FieldOffset(Offset = "0x18")]
		public uint after_emote_id;

		[Token(Token = "0x40035CD")]
		[FieldOffset(Offset = "0x1C")]
		public uint before_emote_id;

		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x22FEA14", Offset = "0x22FEA14", VA = "0x22FEA14")]
		public EventBooyahClickEquip()
		{
		}
	}

	[Token(Token = "0x2000354")]
	public class EventBooyahEmotePlay : EventLoggerBase
	{
		[Token(Token = "0x40035CE")]
		[FieldOffset(Offset = "0x18")]
		public uint emote_id;

		[Token(Token = "0x40035CF")]
		[FieldOffset(Offset = "0x1C")]
		public uint play_num;

		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x22FEA1C", Offset = "0x22FEA1C", VA = "0x22FEA1C")]
		public EventBooyahEmotePlay()
		{
		}
	}

	[Token(Token = "0x2000355")]
	public class EventMallItemClickInfo
	{
		[Token(Token = "0x40035D0")]
		[FieldOffset(Offset = "0x8")]
		public uint shop;

		[Token(Token = "0x40035D1")]
		[FieldOffset(Offset = "0xC")]
		public uint tab1;

		[Token(Token = "0x40035D2")]
		[FieldOffset(Offset = "0x10")]
		public uint tab2;

		[Token(Token = "0x40035D3")]
		[FieldOffset(Offset = "0x14")]
		public uint item_id;

		[Token(Token = "0x40035D4")]
		[FieldOffset(Offset = "0x18")]
		public uint cnt;

		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x22FEAB4", Offset = "0x22FEAB4", VA = "0x22FEAB4")]
		public EventMallItemClickInfo(uint shop, uint tab1, uint tab2, uint item_id, uint cnt)
		{
		}
	}

	[Token(Token = "0x2000356")]
	public class EventChampionshipClickCount : EventLoggerBase
	{
		[Token(Token = "0x40035D5")]
		[FieldOffset(Offset = "0x18")]
		public uint championshipType;

		[Token(Token = "0x40035D6")]
		[FieldOffset(Offset = "0x1C")]
		public uint championshipID;

		[Token(Token = "0x40035D7")]
		[FieldOffset(Offset = "0x20")]
		public uint teamClick;

		[Token(Token = "0x40035D8")]
		[FieldOffset(Offset = "0x24")]
		public uint entranceClick;

		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x22EED38", Offset = "0x22EED38", VA = "0x22EED38")]
		public EventChampionshipClickCount()
		{
		}
	}

	[Token(Token = "0x2000357")]
	public class EventBackBTNLowerLeftClick : EventLoggerBase
	{
		[Token(Token = "0x40035D9")]
		[FieldOffset(Offset = "0x18")]
		public bool is_lower_left;

		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x22F254C", Offset = "0x22F254C", VA = "0x22F254C")]
		public EventBackBTNLowerLeftClick()
		{
		}
	}

	[Token(Token = "0x2000358")]
	public class EventRejectGroupInvite : EventLoggerBase
	{
		[Token(Token = "0x40035DA")]
		[FieldOffset(Offset = "0x18")]
		public ulong inviter_id;

		[Token(Token = "0x40035DB")]
		[FieldOffset(Offset = "0x20")]
		public ulong group_id;

		[Token(Token = "0x40035DC")]
		[FieldOffset(Offset = "0x28")]
		public uint match_mode;

		[Token(Token = "0x40035DD")]
		[FieldOffset(Offset = "0x2C")]
		public uint game_mode;

		[Token(Token = "0x40035DE")]
		[FieldOffset(Offset = "0x30")]
		public uint group_mode;

		[Token(Token = "0x40035DF")]
		[FieldOffset(Offset = "0x34")]
		public uint[] map_ids;

		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x22FEB24", Offset = "0x22FEB24", VA = "0x22FEB24")]
		public EventRejectGroupInvite()
		{
		}
	}

	[Token(Token = "0x2000359")]
	public class EventRejectJoinGroup : EventLoggerBase
	{
		[Token(Token = "0x40035E0")]
		[FieldOffset(Offset = "0x18")]
		public ulong applier_id;

		[Token(Token = "0x40035E1")]
		[FieldOffset(Offset = "0x20")]
		public ulong group_id;

		[Token(Token = "0x40035E2")]
		[FieldOffset(Offset = "0x28")]
		public uint match_mode;

		[Token(Token = "0x40035E3")]
		[FieldOffset(Offset = "0x2C")]
		public uint game_mode;

		[Token(Token = "0x40035E4")]
		[FieldOffset(Offset = "0x30")]
		public uint group_mode;

		[Token(Token = "0x40035E5")]
		[FieldOffset(Offset = "0x34")]
		public uint[] map_ids;

		[Token(Token = "0x40035E6")]
		[FieldOffset(Offset = "0x38")]
		public uint group_type;

		[Token(Token = "0x40035E7")]
		[FieldOffset(Offset = "0x3C")]
		public uint group_size;

		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x22FEB2C", Offset = "0x22FEB2C", VA = "0x22FEB2C")]
		public EventRejectJoinGroup()
		{
		}
	}

	[Token(Token = "0x200035A")]
	public class EventNotiWindowReplaced : EventLoggerBase
	{
		[Token(Token = "0x40035E8")]
		[FieldOffset(Offset = "0x18")]
		public uint old_window_content;

		[Token(Token = "0x40035E9")]
		[FieldOffset(Offset = "0x20")]
		public ulong old_window_exists_time;

		[Token(Token = "0x40035EA")]
		[FieldOffset(Offset = "0x28")]
		public uint new_window_content;

		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x22FEAFC", Offset = "0x22FEAFC", VA = "0x22FEAFC")]
		public EventNotiWindowReplaced()
		{
		}
	}

	[Token(Token = "0x200035B")]
	public class EventSystemScreenShot : EventLoggerBase
	{
		[Token(Token = "0x40035EB")]
		[FieldOffset(Offset = "0x18")]
		public List<string> tags;

		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x22FA6D8", Offset = "0x22FA6D8", VA = "0x22FA6D8")]
		public EventSystemScreenShot()
		{
		}
	}

	[Token(Token = "0x200035C")]
	public enum EventLogScene
	{
		[Token(Token = "0x40035ED")]
		None,
		[Token(Token = "0x40035EE")]
		Login,
		[Token(Token = "0x40035EF")]
		Lobby,
		[Token(Token = "0x40035F0")]
		MatchStart,
		[Token(Token = "0x40035F1")]
		InGame,
		[Token(Token = "0x40035F2")]
		MatchEnd
	}

	[Token(Token = "0x200035D")]
	public enum EventBroadCastType
	{
		[Token(Token = "0x40035F4")]
		None,
		[Token(Token = "0x40035F5")]
		Friends,
		[Token(Token = "0x40035F6")]
		LoudSpeaker,
		[Token(Token = "0x40035F7")]
		Gacha,
		[Token(Token = "0x40035F8")]
		EP,
		[Token(Token = "0x40035F9")]
		InGameDrop
	}

	[Token(Token = "0x200035E")]
	public class EventANO : EventLoggerBase
	{
		[Token(Token = "0x40035FA")]
		[FieldOffset(Offset = "0x18")]
		public uint tickCount;

		[Token(Token = "0x40035FB")]
		[FieldOffset(Offset = "0x1C")]
		public string info;

		[Token(Token = "0x40035FC")]
		[FieldOffset(Offset = "0x20")]
		public int scene;

		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x22FE9F4", Offset = "0x22FE9F4", VA = "0x22FE9F4")]
		public EventANO()
		{
		}
	}

	[Token(Token = "0x200035F")]
	public class EventIngameTips : EventLoggerBase
	{
		[Token(Token = "0x40035FD")]
		[FieldOffset(Offset = "0x18")]
		public uint value;

		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x22FE118", Offset = "0x22FE118", VA = "0x22FE118")]
		public EventIngameTips()
		{
		}
	}

	[Token(Token = "0x2000360")]
	public class EventEnterWaitingIsland : EventEnterGame
	{
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x22FE108", Offset = "0x22FE108", VA = "0x22FE108")]
		public EventEnterWaitingIsland()
		{
		}
	}

	[Token(Token = "0x2000361")]
	public class EventLeaveWaitingIsland : EventLoggerBase
	{
		[Token(Token = "0x40035FE")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x40035FF")]
		[FieldOffset(Offset = "0x20")]
		public uint tick_count;

		[Token(Token = "0x4003600")]
		[FieldOffset(Offset = "0x24")]
		public uint quality;

		[Token(Token = "0x4003601")]
		[FieldOffset(Offset = "0x28")]
		public float enter_battery;

		[Token(Token = "0x4003602")]
		[FieldOffset(Offset = "0x2C")]
		public float leave_battery;

		[Token(Token = "0x4003603")]
		[FieldOffset(Offset = "0x30")]
		public bool is_charge;

		[Token(Token = "0x4003604")]
		[FieldOffset(Offset = "0x31")]
		public bool is_battle_started;

		[Token(Token = "0x4003605")]
		[FieldOffset(Offset = "0x34")]
		public uint resource_load_count;

		[Token(Token = "0x4003606")]
		[FieldOffset(Offset = "0x38")]
		public uint game_time;

		[Token(Token = "0x4003607")]
		[FieldOffset(Offset = "0x3C")]
		public uint group_mode;

		[Token(Token = "0x4003608")]
		[FieldOffset(Offset = "0x40")]
		public int ping;

		[Token(Token = "0x4003609")]
		[FieldOffset(Offset = "0x44")]
		public int maxping;

		[Token(Token = "0x400360A")]
		[FieldOffset(Offset = "0x48")]
		public int ping_total;

		[Token(Token = "0x400360B")]
		[FieldOffset(Offset = "0x4C")]
		public int ping_b500;

		[Token(Token = "0x400360C")]
		[FieldOffset(Offset = "0x50")]
		public int ping_a500;

		[Token(Token = "0x400360D")]
		[FieldOffset(Offset = "0x54")]
		public int ping100200;

		[Token(Token = "0x400360E")]
		[FieldOffset(Offset = "0x58")]
		public int ping200300;

		[Token(Token = "0x400360F")]
		[FieldOffset(Offset = "0x5C")]
		public int ping300400;

		[Token(Token = "0x4003610")]
		[FieldOffset(Offset = "0x60")]
		public int ping400500;

		[Token(Token = "0x4003611")]
		[FieldOffset(Offset = "0x64")]
		public string client_ip;

		[Token(Token = "0x4003612")]
		[FieldOffset(Offset = "0x68")]
		public string country;

		[Token(Token = "0x4003613")]
		[FieldOffset(Offset = "0x6C")]
		public string gameserver_ip;

		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x22FE110", Offset = "0x22FE110", VA = "0x22FE110")]
		public EventLeaveWaitingIsland()
		{
		}
	}

	[Token(Token = "0x2000362")]
	public class IngameEnterGameData
	{
		[Token(Token = "0x4003614")]
		[FieldOffset(Offset = "0x8")]
		public int frameCount;

		[Token(Token = "0x4003615")]
		[FieldOffset(Offset = "0xC")]
		public float time;

		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x22FE120", Offset = "0x22FE120", VA = "0x22FE120")]
		public IngameEnterGameData()
		{
		}
	}

	[Token(Token = "0x2000363")]
	public class EventTrainingLocalGame : EventLoggerBase
	{
		[Serializable]
		[Token(Token = "0x2000364")]
		public class ShootGameScore
		{
			[Token(Token = "0x4003624")]
			[FieldOffset(Offset = "0x8")]
			public int level;

			[Token(Token = "0x4003625")]
			[FieldOffset(Offset = "0xC")]
			public uint score;

			[Token(Token = "0x6000ED8")]
			[Address(RVA = "0x22FEB7C", Offset = "0x22FEB7C", VA = "0x22FEB7C")]
			public ShootGameScore()
			{
			}
		}

		[Token(Token = "0x4003616")]
		[FieldOffset(Offset = "0x18")]
		public uint shooting_game_play_time;

		[Token(Token = "0x4003617")]
		[FieldOffset(Offset = "0x1C")]
		public uint ttl_game_play_time;

		[Token(Token = "0x4003618")]
		[FieldOffset(Offset = "0x20")]
		public uint boxing_game_play_time;

		[Token(Token = "0x4003619")]
		[FieldOffset(Offset = "0x24")]
		public uint vehicle_speed_game_play_time;

		[Token(Token = "0x400361A")]
		[FieldOffset(Offset = "0x28")]
		public uint ice_wall_game_play_time;

		[Token(Token = "0x400361B")]
		[FieldOffset(Offset = "0x2C")]
		public uint ferris_wheel_use_time;

		[Token(Token = "0x400361C")]
		[FieldOffset(Offset = "0x30")]
		public uint take_photo_time;

		[Token(Token = "0x400361D")]
		[FieldOffset(Offset = "0x34")]
		public uint game_result_share_time;

		[Token(Token = "0x400361E")]
		[FieldOffset(Offset = "0x38")]
		public uint craft_gun_use_time;

		[Token(Token = "0x400361F")]
		[FieldOffset(Offset = "0x3C")]
		public uint zepplin_use_time;

		[Token(Token = "0x4003620")]
		[FieldOffset(Offset = "0x40")]
		public uint grenade_game_play_time;

		[Token(Token = "0x4003621")]
		[FieldOffset(Offset = "0x44")]
		public uint video_room_play_time;

		[Token(Token = "0x4003622")]
		[FieldOffset(Offset = "0x48")]
		public uint stage_visit_time;

		[Token(Token = "0x4003623")]
		[FieldOffset(Offset = "0x4C")]
		public List<ShootGameScore> shooting_game_score;

		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x22F93EC", Offset = "0x22F93EC", VA = "0x22F93EC")]
		public EventTrainingLocalGame()
		{
		}
	}

	[Token(Token = "0x2000365")]
	public class EventCustomRoomVoiceChat : EventLoggerBase
	{
		[Token(Token = "0x4003626")]
		[FieldOffset(Offset = "0x18")]
		public ulong room_id;

		[Token(Token = "0x4003627")]
		[FieldOffset(Offset = "0x20")]
		public ulong match_id;

		[Token(Token = "0x4003628")]
		[FieldOffset(Offset = "0x28")]
		public uint room_type;

		[Token(Token = "0x4003629")]
		[FieldOffset(Offset = "0x2C")]
		public uint game_mode;

		[Token(Token = "0x400362A")]
		[FieldOffset(Offset = "0x30")]
		public uint group_mode;

		[Token(Token = "0x400362B")]
		[FieldOffset(Offset = "0x34")]
		public bool is_ob;

		[Token(Token = "0x400362C")]
		[FieldOffset(Offset = "0x38")]
		public uint click_mic_cnt;

		[Token(Token = "0x400362D")]
		[FieldOffset(Offset = "0x3C")]
		public uint click_horn_cnt;

		[Token(Token = "0x400362E")]
		[FieldOffset(Offset = "0x40")]
		public bool is_mic_on;

		[Token(Token = "0x400362F")]
		[FieldOffset(Offset = "0x41")]
		public bool is_horn_on;

		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x22F98BC", Offset = "0x22F98BC", VA = "0x22F98BC")]
		public EventCustomRoomVoiceChat()
		{
		}
	}

	[Token(Token = "0x2000366")]
	public class EventWereWolvesGame : EventLoggerBase
	{
		[Token(Token = "0x4003630")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x4003631")]
		[FieldOffset(Offset = "0x20")]
		public uint mic_count;

		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x22F9E28", Offset = "0x22F9E28", VA = "0x22F9E28")]
		public EventWereWolvesGame()
		{
		}
	}

	[Token(Token = "0x2000367")]
	public class EventLocalNotificationStats : EventLoggerBase
	{
		[Token(Token = "0x2000368")]
		public class Channel
		{
			[Token(Token = "0x4003636")]
			[FieldOffset(Offset = "0x8")]
			public string type;

			[Token(Token = "0x4003637")]
			[FieldOffset(Offset = "0xC")]
			public bool if_enable;

			[Token(Token = "0x6000EDC")]
			[Address(RVA = "0x22FEA7C", Offset = "0x22FEA7C", VA = "0x22FEA7C")]
			public Channel()
			{
			}
		}

		[Token(Token = "0x2000369")]
		public class TypeCount
		{
			[Token(Token = "0x4003638")]
			[FieldOffset(Offset = "0x8")]
			public string type;

			[Token(Token = "0x4003639")]
			[FieldOffset(Offset = "0xC")]
			public int cnt;

			[Token(Token = "0x6000EDD")]
			[Address(RVA = "0x22FEA84", Offset = "0x22FEA84", VA = "0x22FEA84")]
			public TypeCount(string k, int v)
			{
			}
		}

		[Token(Token = "0x4003632")]
		[FieldOffset(Offset = "0x18")]
		public bool if_enable;

		[Token(Token = "0x4003633")]
		[FieldOffset(Offset = "0x1C")]
		public List<Channel> channels;

		[Token(Token = "0x4003634")]
		[FieldOffset(Offset = "0x20")]
		public List<TypeCount> notifies;

		[Token(Token = "0x4003635")]
		[FieldOffset(Offset = "0x24")]
		public List<TypeCount> clicks;

		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x22FEA74", Offset = "0x22FEA74", VA = "0x22FEA74")]
		public EventLocalNotificationStats()
		{
		}
	}

	[Token(Token = "0x200036A")]
	public class EventReplaySetting : EventLoggerBase
	{
		[Token(Token = "0x400363A")]
		[FieldOffset(Offset = "0x18")]
		public bool if_open;

		[Token(Token = "0x400363B")]
		[FieldOffset(Offset = "0x19")]
		public bool if_available;

		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x22FEB3C", Offset = "0x22FEB3C", VA = "0x22FEB3C")]
		public EventReplaySetting()
		{
		}
	}

	[Token(Token = "0x200036B")]
	public class EventUniversalLinkGoto : EventLoggerBase
	{
		[Token(Token = "0x400363C")]
		[FieldOffset(Offset = "0x18")]
		public string universal_link;

		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x22FCD38", Offset = "0x22FCD38", VA = "0x22FCD38")]
		public EventUniversalLinkGoto()
		{
		}
	}

	[Token(Token = "0x200036C")]
	public class EventUGCLoginInfo : EventLoggerBase
	{
		[Token(Token = "0x400363D")]
		[FieldOffset(Offset = "0x18")]
		public uint ugc_level;

		[Token(Token = "0x400363E")]
		[FieldOffset(Offset = "0x1C")]
		public uint ugc_exp;

		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x22FCFA4", Offset = "0x22FCFA4", VA = "0x22FCFA4")]
		public EventUGCLoginInfo()
		{
		}
	}

	[Token(Token = "0x200036D")]
	public class EventTypeCupLoginAnimation : EventLoggerBase
	{
		[Token(Token = "0x400363F")]
		[FieldOffset(Offset = "0x18")]
		public bool is_click;

		[Token(Token = "0x4003640")]
		[FieldOffset(Offset = "0x1C")]
		public uint cup_type;

		[Token(Token = "0x4003641")]
		[FieldOffset(Offset = "0x20")]
		public uint cup_id;

		[Token(Token = "0x4003642")]
		[FieldOffset(Offset = "0x24")]
		public uint animation_type;

		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x22FD11C", Offset = "0x22FD11C", VA = "0x22FD11C")]
		public EventTypeCupLoginAnimation()
		{
		}
	}

	[Token(Token = "0x200036E")]
	public class EventTypeFullScreenAnimation : EventLoggerBase
	{
		[Token(Token = "0x4003643")]
		[FieldOffset(Offset = "0x18")]
		public uint id;

		[Token(Token = "0x4003644")]
		[FieldOffset(Offset = "0x1C")]
		public uint anim_id;

		[Token(Token = "0x4003645")]
		[FieldOffset(Offset = "0x20")]
		public uint anim_type;

		[Token(Token = "0x4003646")]
		[FieldOffset(Offset = "0x24")]
		public uint system_pos;

		[Token(Token = "0x4003647")]
		[FieldOffset(Offset = "0x28")]
		public uint go_pos;

		[Token(Token = "0x4003648")]
		[FieldOffset(Offset = "0x2C")]
		public string full_screen_resource_id;

		[Token(Token = "0x4003649")]
		[FieldOffset(Offset = "0x30")]
		public string skin_resource_list;

		[Token(Token = "0x400364A")]
		[FieldOffset(Offset = "0x34")]
		public uint lottery_id;

		[Token(Token = "0x400364B")]
		[FieldOffset(Offset = "0x38")]
		public uint lottery_sub_id;

		[Token(Token = "0x400364C")]
		[FieldOffset(Offset = "0x3C")]
		public uint season;

		[Token(Token = "0x400364D")]
		[FieldOffset(Offset = "0x40")]
		public float play_time;

		[Token(Token = "0x400364E")]
		[FieldOffset(Offset = "0x44")]
		public float animation_time;

		[Token(Token = "0x400364F")]
		[FieldOffset(Offset = "0x48")]
		public uint is_play_actively;

		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x22FD3E4", Offset = "0x22FD3E4", VA = "0x22FD3E4")]
		public EventTypeFullScreenAnimation()
		{
		}
	}

	[Token(Token = "0x200036F")]
	public class EventTypeMaxQualityABTestSetting : EventLoggerBase
	{
		[Token(Token = "0x4003650")]
		[FieldOffset(Offset = "0x18")]
		public string device_id;

		[Token(Token = "0x4003651")]
		[FieldOffset(Offset = "0x1C")]
		public uint group_name;

		[Token(Token = "0x4003652")]
		[FieldOffset(Offset = "0x20")]
		public uint final_quality;

		[Token(Token = "0x4003653")]
		[FieldOffset(Offset = "0x24")]
		public int final_hd_audio;

		[Token(Token = "0x4003654")]
		[FieldOffset(Offset = "0x28")]
		public int final_hd_animation;

		[Token(Token = "0x4003655")]
		[FieldOffset(Offset = "0x2C")]
		public int final_hd_weapon_effect;

		[Token(Token = "0x4003656")]
		[FieldOffset(Offset = "0x30")]
		public int final_hd_texture;

		[Token(Token = "0x4003657")]
		[FieldOffset(Offset = "0x34")]
		public int final_hd_vehicle_effect;

		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x22FDC44", Offset = "0x22FDC44", VA = "0x22FDC44")]
		public EventTypeMaxQualityABTestSetting()
		{
		}
	}

	[Token(Token = "0x2000370")]
	public class EventTypeGuestSAFPermission : EventLoggerBase
	{
		[Token(Token = "0x4003658")]
		[FieldOffset(Offset = "0x18")]
		public int migrate_result;

		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x22FD4F8", Offset = "0x22FD4F8", VA = "0x22FD4F8")]
		public EventTypeGuestSAFPermission()
		{
		}
	}

	[Token(Token = "0x2000371")]
	public class EventTypeMapSelected : EventLoggerBase
	{
		[Token(Token = "0x4003659")]
		[FieldOffset(Offset = "0x18")]
		public uint match_mode;

		[Token(Token = "0x400365A")]
		[FieldOffset(Offset = "0x1C")]
		public uint game_mode;

		[Token(Token = "0x400365B")]
		[FieldOffset(Offset = "0x20")]
		public uint[] map_id_list;

		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x22FD670", Offset = "0x22FD670", VA = "0x22FD670")]
		public EventTypeMapSelected()
		{
		}
	}

	[Token(Token = "0x2000372")]
	public class EventTypeBanVoice : EventLoggerBase
	{
		[Token(Token = "0x400365C")]
		[FieldOffset(Offset = "0x18")]
		public new ulong account_id;

		[Token(Token = "0x400365D")]
		[FieldOffset(Offset = "0x20")]
		public new string region;

		[Token(Token = "0x400365E")]
		[FieldOffset(Offset = "0x24")]
		public uint behavior_rule_id;

		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x22FEB94", Offset = "0x22FEB94", VA = "0x22FEB94")]
		public EventTypeBanVoice()
		{
		}
	}

	[Token(Token = "0x2000373")]
	public class EventTypePopupWindowViewTime : EventLoggerBase
	{
		[Token(Token = "0x2000374")]
		public class SinglePopupWindowViewTime
		{
			[Token(Token = "0x4003660")]
			[FieldOffset(Offset = "0x8")]
			public string window_name;

			[Token(Token = "0x4003661")]
			[FieldOffset(Offset = "0xC")]
			public int view_time;

			[Token(Token = "0x4003662")]
			[FieldOffset(Offset = "0x10")]
			public int cnt;

			[Token(Token = "0x6000EE8")]
			[Address(RVA = "0x22F42B4", Offset = "0x22F42B4", VA = "0x22F42B4")]
			public SinglePopupWindowViewTime()
			{
			}

			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0x22FEBD4", Offset = "0x22FEBD4", VA = "0x22FEBD4")]
			public SinglePopupWindowViewTime(string windowName, int viewTime, int count)
			{
			}
		}

		[Token(Token = "0x400365F")]
		[FieldOffset(Offset = "0x18")]
		public List<SinglePopupWindowViewTime> views;

		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x22F42AC", Offset = "0x22F42AC", VA = "0x22F42AC")]
		public EventTypePopupWindowViewTime()
		{
		}
	}

	[Token(Token = "0x2000375")]
	public class EventTypeFriendRecommendPopup : EventLoggerBase
	{
		[Token(Token = "0x4003663")]
		[FieldOffset(Offset = "0x18")]
		public ulong recommend_account_id;

		[Token(Token = "0x4003664")]
		[FieldOffset(Offset = "0x20")]
		public int status;

		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x22FD7C0", Offset = "0x22FD7C0", VA = "0x22FD7C0")]
		public EventTypeFriendRecommendPopup()
		{
		}
	}

	[Token(Token = "0x2000376")]
	public class EventTypeMvpGroupInvitePopup : EventLoggerBase
	{
		[Token(Token = "0x4003665")]
		[FieldOffset(Offset = "0x18")]
		public ulong mvp_account_id;

		[Token(Token = "0x4003666")]
		[FieldOffset(Offset = "0x20")]
		public int status;

		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x22FD910", Offset = "0x22FD910", VA = "0x22FD910")]
		public EventTypeMvpGroupInvitePopup()
		{
		}
	}

	[Token(Token = "0x2000377")]
	public enum ECupLoginAnimationType
	{
		[Token(Token = "0x4003668")]
		BeforeMatchStart,
		[Token(Token = "0x4003669")]
		AfterMatchStart
	}

	[Token(Token = "0x2000378")]
	public enum ERecommendPopupStatus
	{
		[Token(Token = "0x400366B")]
		PopUp,
		[Token(Token = "0x400366C")]
		Confirm,
		[Token(Token = "0x400366D")]
		Cancle
	}

	[Token(Token = "0x2000379")]
	public enum EGameTimeType
	{
		[Token(Token = "0x400366F")]
		EnterPVP,
		[Token(Token = "0x4003670")]
		LeavePVP
	}

	[Token(Token = "0x200037A")]
	public enum EDisconnectionType
	{
		[Token(Token = "0x4003672")]
		TCP,
		[Token(Token = "0x4003673")]
		UDP_ENTER,
		[Token(Token = "0x4003674")]
		UDP_INGAME
	}

	[Token(Token = "0x200037B")]
	public enum BuildVariantType
	{
		[Token(Token = "0x4003676")]
		Normal,
		[Token(Token = "0x4003677")]
		Max
	}

	[Token(Token = "0x200037C")]
	public class EventLoginInfo
	{
		[Token(Token = "0x4003678")]
		[FieldOffset(Offset = "0x8")]
		public ulong account_id;

		[Token(Token = "0x4003679")]
		[FieldOffset(Offset = "0x10")]
		public string game_server_id;

		[Token(Token = "0x400367A")]
		[FieldOffset(Offset = "0x14")]
		public string event_time;

		[Token(Token = "0x400367B")]
		[FieldOffset(Offset = "0x18")]
		public string game_id;

		[Token(Token = "0x400367C")]
		[FieldOffset(Offset = "0x1C")]
		public int plat_id;

		[Token(Token = "0x400367D")]
		[FieldOffset(Offset = "0x20")]
		public int zone_area_id;

		[Token(Token = "0x400367E")]
		[FieldOffset(Offset = "0x24")]
		public string client_version;

		[Token(Token = "0x400367F")]
		[FieldOffset(Offset = "0x28")]
		public string client_version_code;

		[Token(Token = "0x4003680")]
		[FieldOffset(Offset = "0x2C")]
		public string system_software;

		[Token(Token = "0x4003681")]
		[FieldOffset(Offset = "0x30")]
		public string system_hardware;

		[Token(Token = "0x4003682")]
		[FieldOffset(Offset = "0x34")]
		public string system_graphics_api;

		[Token(Token = "0x4003683")]
		[FieldOffset(Offset = "0x38")]
		public uint supported_astc_bitset;

		[Token(Token = "0x4003684")]
		[FieldOffset(Offset = "0x3C")]
		public string telecom_oper;

		[Token(Token = "0x4003685")]
		[FieldOffset(Offset = "0x40")]
		public string network;

		[Token(Token = "0x4003686")]
		[FieldOffset(Offset = "0x44")]
		public int screen_width;

		[Token(Token = "0x4003687")]
		[FieldOffset(Offset = "0x48")]
		public int screen_hight;

		[Token(Token = "0x4003688")]
		[FieldOffset(Offset = "0x4C")]
		public string dpi;

		[Token(Token = "0x4003689")]
		[FieldOffset(Offset = "0x50")]
		public string cpu_hardware;

		[Token(Token = "0x400368A")]
		[FieldOffset(Offset = "0x54")]
		public int memory;

		[Token(Token = "0x400368B")]
		[FieldOffset(Offset = "0x58")]
		public string gl_render;

		[Token(Token = "0x400368C")]
		[FieldOffset(Offset = "0x5C")]
		public string gl_version;

		[Token(Token = "0x400368D")]
		[FieldOffset(Offset = "0x60")]
		public string device_id;

		[Token(Token = "0x400368E")]
		[FieldOffset(Offset = "0x64")]
		public string client_ip;

		[Token(Token = "0x400368F")]
		[FieldOffset(Offset = "0x68")]
		public string language;

		[Token(Token = "0x4003690")]
		[FieldOffset(Offset = "0x6C")]
		public string open_id;

		[Token(Token = "0x4003691")]
		[FieldOffset(Offset = "0x70")]
		public string open_id_type;

		[Token(Token = "0x4003692")]
		[FieldOffset(Offset = "0x74")]
		public string device_type;

		[Token(Token = "0x4003693")]
		[FieldOffset(Offset = "0x78")]
		public string device_model;

		[Token(Token = "0x4003694")]
		[FieldOffset(Offset = "0x7C")]
		public string region;

		[Token(Token = "0x4003695")]
		[FieldOffset(Offset = "0x80")]
		public string others;

		[Token(Token = "0x4003696")]
		[FieldOffset(Offset = "0x84")]
		public int sdcard_total_storage;

		[Token(Token = "0x4003697")]
		[FieldOffset(Offset = "0x88")]
		public int sdcard_avail_storage;

		[Token(Token = "0x4003698")]
		[FieldOffset(Offset = "0x8C")]
		public int inner_total_storage;

		[Token(Token = "0x4003699")]
		[FieldOffset(Offset = "0x90")]
		public int inner_avail_storage;

		[Token(Token = "0x400369A")]
		[FieldOffset(Offset = "0x94")]
		public string lib_token;

		[Token(Token = "0x400369B")]
		[FieldOffset(Offset = "0x98")]
		public string serial_a;

		[Token(Token = "0x400369C")]
		[FieldOffset(Offset = "0x9C")]
		public string board_a;

		[Token(Token = "0x400369D")]
		[FieldOffset(Offset = "0xA0")]
		public string brand_a;

		[Token(Token = "0x400369E")]
		[FieldOffset(Offset = "0xA4")]
		public string fingerprint_a;

		[Token(Token = "0x400369F")]
		[FieldOffset(Offset = "0xA8")]
		public string hardware_a;

		[Token(Token = "0x40036A0")]
		[FieldOffset(Offset = "0xAC")]
		public string manufacturer_a;

		[Token(Token = "0x40036A1")]
		[FieldOffset(Offset = "0xB0")]
		public string bootloader_a;

		[Token(Token = "0x40036A2")]
		[FieldOffset(Offset = "0xB4")]
		public string device_a;

		[Token(Token = "0x40036A3")]
		[FieldOffset(Offset = "0xB8")]
		public string model_a;

		[Token(Token = "0x40036A4")]
		[FieldOffset(Offset = "0xBC")]
		public string product_a;

		[Token(Token = "0x40036A5")]
		[FieldOffset(Offset = "0xC0")]
		public string network_operator_a;

		[Token(Token = "0x40036A6")]
		[FieldOffset(Offset = "0xC4")]
		public string network_type_a;

		[Token(Token = "0x40036A7")]
		[FieldOffset(Offset = "0xC8")]
		public string imei_a;

		[Token(Token = "0x40036A8")]
		[FieldOffset(Offset = "0xCC")]
		public string meid_a;

		[Token(Token = "0x40036A9")]
		[FieldOffset(Offset = "0xD0")]
		public string subscriber_a;

		[Token(Token = "0x40036AA")]
		[FieldOffset(Offset = "0xD4")]
		public bool check_emulator_files_a;

		[Token(Token = "0x40036AB")]
		[FieldOffset(Offset = "0xD5")]
		public bool check_emulator_properties_a;

		[Token(Token = "0x40036AC")]
		[FieldOffset(Offset = "0xD6")]
		public bool check_emulator_packages_a;

		[Token(Token = "0x40036AD")]
		[FieldOffset(Offset = "0xD8")]
		public ulong check_emulator_files_list_a;

		[Token(Token = "0x40036AE")]
		[FieldOffset(Offset = "0xE0")]
		public ulong check_emulator_properties_list_a;

		[Token(Token = "0x40036AF")]
		[FieldOffset(Offset = "0xE8")]
		public ulong check_emulator_packages_list_a;

		[Token(Token = "0x40036B0")]
		[FieldOffset(Offset = "0xF0")]
		public bool is_root;

		[Token(Token = "0x40036B1")]
		[FieldOffset(Offset = "0xF4")]
		public string signature_md5;

		[Token(Token = "0x40036B2")]
		[FieldOffset(Offset = "0xF8")]
		public string sensor_info;

		[Token(Token = "0x40036B3")]
		[FieldOffset(Offset = "0xFC")]
		public int game_installed_disk_avail_storage;

		[Token(Token = "0x40036B4")]
		[FieldOffset(Offset = "0x100")]
		public int game_installed_disk_total_storage;

		[Token(Token = "0x40036B5")]
		[FieldOffset(Offset = "0x104")]
		public int external_sdcard_avail_storage;

		[Token(Token = "0x40036B6")]
		[FieldOffset(Offset = "0x108")]
		public int external_sdcard_total_storage;

		[Token(Token = "0x40036B7")]
		[FieldOffset(Offset = "0x10C")]
		public string cpu_architecture;

		[Token(Token = "0x40036B8")]
		[FieldOffset(Offset = "0x110")]
		public uint channel_type;

		[Token(Token = "0x40036B9")]
		[FieldOffset(Offset = "0x114")]
		public uint cpu_type;

		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x22EB134", Offset = "0x22EB134", VA = "0x22EB134")]
		public EventLoginInfo()
		{
		}
	}

	[Token(Token = "0x200037D")]
	public enum SharePlatform
	{
		[Token(Token = "0x40036BB")]
		None = 0,
		[Token(Token = "0x40036BC")]
		Garena = 1,
		[Token(Token = "0x40036BD")]
		Facebook = 2,
		[Token(Token = "0x40036BE")]
		VKontakte = 3,
		[Token(Token = "0x40036BF")]
		Line = 4,
		[Token(Token = "0x40036C0")]
		FacebookMessenger = 5,
		[Token(Token = "0x40036C1")]
		CopyLink = 6,
		[Token(Token = "0x40036C2")]
		System = 99
	}

	[Serializable]
	[Token(Token = "0x200037E")]
	public class ScanIAPInventoryResult
	{
		[Token(Token = "0x40036C3")]
		[FieldOffset(Offset = "0x8")]
		public string item_identifier;

		[Token(Token = "0x40036C4")]
		[FieldOffset(Offset = "0xC")]
		public string error;

		[Token(Token = "0x40036C5")]
		[FieldOffset(Offset = "0x10")]
		public bool success;

		[Token(Token = "0x40036C6")]
		[FieldOffset(Offset = "0x14")]
		public int amount;

		[Token(Token = "0x40036C7")]
		[FieldOffset(Offset = "0x18")]
		public bool promotion;

		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x22FF050", Offset = "0x22FF050", VA = "0x22FF050")]
		public ScanIAPInventoryResult()
		{
		}
	}

	[Token(Token = "0x200037F")]
	public enum ChampioshipClickType
	{
		[Token(Token = "0x40036C9")]
		Entrance,
		[Token(Token = "0x40036CA")]
		Team
	}

	[Token(Token = "0x2000380")]
	public enum ClickType
	{
		[Token(Token = "0x40036CC")]
		None = 0,
		[Token(Token = "0x40036CD")]
		Setting = 1,
		[Token(Token = "0x40036CE")]
		Pay = 2,
		[Token(Token = "0x40036CF")]
		Lobby = 3,
		[Token(Token = "0x40036D0")]
		Integrate = 4,
		[Token(Token = "0x40036D1")]
		Avatar = 5,
		[Token(Token = "0x40036D2")]
		AvatarProfile = 6,
		[Token(Token = "0x40036D3")]
		Inventory = 7,
		[Token(Token = "0x40036D4")]
		UniversalDebrisWindow = 8,
		[Token(Token = "0x40036D5")]
		Friend = 9,
		[Token(Token = "0x40036D6")]
		Chat = 10,
		[Token(Token = "0x40036D7")]
		IAP = 11,
		[Token(Token = "0x40036D8")]
		Activity = 12,
		[Token(Token = "0x40036D9")]
		ElitePass = 14,
		[Token(Token = "0x40036DA")]
		Mall = 15,
		[Token(Token = "0x40036DB")]
		Gacha = 17,
		[Token(Token = "0x40036DC")]
		WeaponSkinLobby = 19,
		[Token(Token = "0x40036DD")]
		Championship = 20,
		[Token(Token = "0x40036DE")]
		WeaponSkinUpgrader = 21,
		[Token(Token = "0x40036DF")]
		Profile = 22,
		[Token(Token = "0x40036E0")]
		Pet = 25,
		[Token(Token = "0x40036E1")]
		Clan = 26,
		[Token(Token = "0x40036E2")]
		LiveTv = 27,
		[Token(Token = "0x40036E3")]
		LeaderBoard = 29,
		[Token(Token = "0x40036E4")]
		CommonPopMenu = 30,
		[Token(Token = "0x40036E5")]
		Reservation = 31,
		[Token(Token = "0x40036E6")]
		HudVehicleHorn = 32,
		[Token(Token = "0x40036E7")]
		WeaponRack = 33,
		[Token(Token = "0x40036E8")]
		Forge = 34,
		[Token(Token = "0x40036E9")]
		PortraitCloseup = 35,
		[Token(Token = "0x40036EA")]
		DriftBottleAddFriend = 38,
		[Token(Token = "0x40036EB")]
		FFWS = 39,
		[Token(Token = "0x40036EC")]
		CSWebTutorial = 40,
		[Token(Token = "0x40036ED")]
		TokenTips = 42,
		[Token(Token = "0x40036EE")]
		HDVehicleDisplay = 43,
		[Token(Token = "0x40036EF")]
		HDWeaponRack = 44,
		[Token(Token = "0x40036F0")]
		MatchResult = 45,
		[Token(Token = "0x40036F1")]
		CupMatch = 46,
		[Token(Token = "0x40036F2")]
		HDIceWallDisplay = 47,
		[Token(Token = "0x40036F3")]
		Sutorito = 48,
		[Token(Token = "0x40036F4")]
		Workshop = 49,
		[Token(Token = "0x40036F5")]
		FourSymbols = 50,
		[Token(Token = "0x40036F6")]
		TopUpEvent = 53,
		[Token(Token = "0x40036F7")]
		MallPurchaseWnd = 54,
		[Token(Token = "0x40036F8")]
		Manual = 55,
		[Token(Token = "0x40036F9")]
		HDSkyboardDisplay = 56,
		[Token(Token = "0x40036FA")]
		ClanWarRecruit = 57,
		[Token(Token = "0x40036FB")]
		CSWeaponShop = 58,
		[Token(Token = "0x40036FC")]
		Veteran = 59,
		[Token(Token = "0x40036FD")]
		NewPlayer = 60,
		[Token(Token = "0x40036FE")]
		NewVault = 61,
		[Token(Token = "0x40036FF")]
		TutorialInGame = 62,
		[Token(Token = "0x4003700")]
		AvatarLink = 63,
		[Token(Token = "0x4003701")]
		DressUp = 64,
		[Token(Token = "0x4003702")]
		MatchResultReward = 65,
		[Token(Token = "0x4003703")]
		HudInGame = 66,
		[Token(Token = "0x4003704")]
		TraningCamp = 67,
		[Token(Token = "0x4003705")]
		BigEvent = 77,
		[Token(Token = "0x4003706")]
		BigEventTemplate = 78,
		[Token(Token = "0x4003707")]
		QuitInGame = 79,
		[Token(Token = "0x4003708")]
		Mail = 80,
		[Token(Token = "0x4003709")]
		LadderMatch = 81,
		[Token(Token = "0x400370A")]
		Preview = 82,
		[Token(Token = "0x400370B")]
		HyperBook = 83,
		[Token(Token = "0x400370C")]
		Lab = 84,
		[Token(Token = "0x400370D")]
		FlashStore = 85,
		[Token(Token = "0x400370E")]
		SecretMessage = 86,
		[Token(Token = "0x400370F")]
		Medkit = 87,
		[Token(Token = "0x4003710")]
		Grenade = 88,
		[Token(Token = "0x4003711")]
		SingersBMatchMakingType = 89,
		[Token(Token = "0x4003712")]
		SingersMoiveCamera = 90,
		[Token(Token = "0x4003713")]
		Replay = 91
	}

	[Token(Token = "0x2000381")]
	public enum EventLog_Optional_Operation
	{
		[Token(Token = "0x4003715")]
		None,
		[Token(Token = "0x4003716")]
		Delete
	}

	[Token(Token = "0x2000382")]
	public enum ESingersBMiniGameLogType
	{
		[Token(Token = "0x4003718")]
		ESingersBMiniGameLogType_Stick = 1,
		[Token(Token = "0x4003719")]
		ESingersBMiniGameLogType_Buff,
		[Token(Token = "0x400371A")]
		ESingersBMiniGameLogType_CallDance
	}

	[Token(Token = "0x2000383")]
	public class EventClientPushSetting : EventLoggerBase
	{
		[Token(Token = "0x400371B")]
		[FieldOffset(Offset = "0x18")]
		public bool friend_apply_push;

		[Token(Token = "0x400371C")]
		[FieldOffset(Offset = "0x19")]
		public bool is_support_hardware_decoding;

		[Token(Token = "0x400371D")]
		[FieldOffset(Offset = "0x1C")]
		public int max_login_video;

		[Token(Token = "0x400371E")]
		[FieldOffset(Offset = "0x20")]
		public int max_lobby;

		[Token(Token = "0x400371F")]
		[FieldOffset(Offset = "0x24")]
		public int max_lobby_motion;

		[Token(Token = "0x4003720")]
		[FieldOffset(Offset = "0x28")]
		public int max_audio_style;

		[Token(Token = "0x4003721")]
		[FieldOffset(Offset = "0x2C")]
		public int max_animation;

		[Token(Token = "0x4003722")]
		[FieldOffset(Offset = "0x30")]
		public int max_special_effects;

		[Token(Token = "0x4003723")]
		[FieldOffset(Offset = "0x34")]
		public int max_hd_texture;

		[Token(Token = "0x4003724")]
		[FieldOffset(Offset = "0x38")]
		public int max_vehicle_VFX;

		[Token(Token = "0x4003725")]
		[FieldOffset(Offset = "0x3C")]
		public bool is_first_login;

		[Token(Token = "0x4003726")]
		[FieldOffset(Offset = "0x40")]
		public string device_model;

		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x22FE0C8", Offset = "0x22FE0C8", VA = "0x22FE0C8")]
		public EventClientPushSetting()
		{
		}
	}

	[Token(Token = "0x2000384")]
	public class EventTypeBigBannerGoto : EventLoggerBase
	{
		[Token(Token = "0x4003727")]
		[FieldOffset(Offset = "0x18")]
		public int goto_pos;

		[Token(Token = "0x4003728")]
		[FieldOffset(Offset = "0x1C")]
		public string sub_goto_pos;

		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x22F8C28", Offset = "0x22F8C28", VA = "0x22F8C28")]
		public EventTypeBigBannerGoto()
		{
		}
	}

	[Token(Token = "0x2000385")]
	public class EventTypeFriendRecommend : EventLoggerBase
	{
		[Token(Token = "0x4003729")]
		[FieldOffset(Offset = "0x18")]
		public int recommend_type;

		[Token(Token = "0x400372A")]
		[FieldOffset(Offset = "0x20")]
		public ulong recommend_account_id;

		[Token(Token = "0x400372B")]
		[FieldOffset(Offset = "0x28")]
		public int recommend_account_rank;

		[Token(Token = "0x400372C")]
		[FieldOffset(Offset = "0x2C")]
		public bool if_shield;

		[Token(Token = "0x400372D")]
		[FieldOffset(Offset = "0x30")]
		public int choose;

		[Token(Token = "0x400372E")]
		[FieldOffset(Offset = "0x34")]
		public int cur_friend_num;

		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x22F8E94", Offset = "0x22F8E94", VA = "0x22F8E94")]
		public EventTypeFriendRecommend()
		{
		}
	}

	[Token(Token = "0x2000386")]
	public class EventTypeVNLink : EventLoggerBase
	{
		[Token(Token = "0x400372F")]
		[FieldOffset(Offset = "0x18")]
		public bool is_transfer;

		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x22F9000", Offset = "0x22F9000", VA = "0x22F9000")]
		public EventTypeVNLink()
		{
		}
	}

	[Token(Token = "0x2000387")]
	public class EventTypeMaxLobbyYard : EventLoggerBase
	{
		[Token(Token = "0x4003730")]
		[FieldOffset(Offset = "0x18")]
		public int edit_time;

		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x22F9278", Offset = "0x22F9278", VA = "0x22F9278")]
		public EventTypeMaxLobbyYard()
		{
		}
	}

	[Token(Token = "0x2000388")]
	public class EventTypeMVPInfo : EventLoggerBase
	{
		[Token(Token = "0x4003731")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x4003732")]
		[FieldOffset(Offset = "0x20")]
		public string ip_region;

		[Token(Token = "0x4003733")]
		[FieldOffset(Offset = "0x24")]
		public uint map_id;

		[Token(Token = "0x4003734")]
		[FieldOffset(Offset = "0x28")]
		public uint game_mode;

		[Token(Token = "0x4003735")]
		[FieldOffset(Offset = "0x2C")]
		public uint group_mode;

		[Token(Token = "0x4003736")]
		[FieldOffset(Offset = "0x30")]
		public uint match_mode;

		[Token(Token = "0x4003737")]
		[FieldOffset(Offset = "0x34")]
		public uint rank;

		[Token(Token = "0x4003738")]
		[FieldOffset(Offset = "0x38")]
		public bool if_mvp;

		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x22FA9E8", Offset = "0x22FA9E8", VA = "0x22FA9E8")]
		public EventTypeMVPInfo()
		{
		}
	}

	[Token(Token = "0x2000389")]
	public class EventTypeRegisterIntitle : EventLoggerBase
	{
		[Token(Token = "0x4003739")]
		[FieldOffset(Offset = "0x18")]
		public uint intitle_time;

		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x22FAB38", Offset = "0x22FAB38", VA = "0x22FAB38")]
		public EventTypeRegisterIntitle()
		{
		}
	}

	[Token(Token = "0x200038A")]
	public class EventTypeReplaySaveStats : EventLoggerBase
	{
		[Token(Token = "0x400373A")]
		[FieldOffset(Offset = "0x18")]
		public bool if_success;

		[Token(Token = "0x400373B")]
		[FieldOffset(Offset = "0x1C")]
		public uint match_mode;

		[Token(Token = "0x400373C")]
		[FieldOffset(Offset = "0x20")]
		public uint game_mode;

		[Token(Token = "0x400373D")]
		[FieldOffset(Offset = "0x24")]
		public uint group_mode;

		[Token(Token = "0x400373E")]
		[FieldOffset(Offset = "0x28")]
		public byte rank;

		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x22FACC8", Offset = "0x22FACC8", VA = "0x22FACC8")]
		public EventTypeReplaySaveStats()
		{
		}
	}

	[Token(Token = "0x200038B")]
	public class EventTypeHighlightsTrigger : EventLoggerBase
	{
		[Token(Token = "0x400373F")]
		[FieldOffset(Offset = "0x18")]
		public uint match_mode;

		[Token(Token = "0x4003740")]
		[FieldOffset(Offset = "0x1C")]
		public uint game_mode;

		[Token(Token = "0x4003741")]
		[FieldOffset(Offset = "0x20")]
		public uint group_mode;

		[Token(Token = "0x4003742")]
		[FieldOffset(Offset = "0x24")]
		public uint map_id;

		[Token(Token = "0x4003743")]
		[FieldOffset(Offset = "0x28")]
		public ulong match_id;

		[Token(Token = "0x4003744")]
		[FieldOffset(Offset = "0x30")]
		public uint time;

		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x22FAEA8", Offset = "0x22FAEA8", VA = "0x22FAEA8")]
		public EventTypeHighlightsTrigger()
		{
		}
	}

	[Token(Token = "0x200038C")]
	public class EventTypeReplaySaveInfo : EventLoggerBase
	{
		[Token(Token = "0x4003745")]
		[FieldOffset(Offset = "0x18")]
		public uint match_mode;

		[Token(Token = "0x4003746")]
		[FieldOffset(Offset = "0x1C")]
		public uint game_mode;

		[Token(Token = "0x4003747")]
		[FieldOffset(Offset = "0x20")]
		public uint group_mode;

		[Token(Token = "0x4003748")]
		[FieldOffset(Offset = "0x24")]
		public uint map_id;

		[Token(Token = "0x4003749")]
		[FieldOffset(Offset = "0x28")]
		public ulong match_id;

		[Token(Token = "0x400374A")]
		[FieldOffset(Offset = "0x30")]
		public uint channel;

		[Token(Token = "0x400374B")]
		[FieldOffset(Offset = "0x34")]
		public bool if_highlights;

		[Token(Token = "0x400374C")]
		[FieldOffset(Offset = "0x38")]
		public uint replay_time;

		[Token(Token = "0x400374D")]
		[FieldOffset(Offset = "0x3C")]
		public uint highlights_time;

		[Token(Token = "0x400374E")]
		[FieldOffset(Offset = "0x40")]
		public byte rank;

		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x22FB12C", Offset = "0x22FB12C", VA = "0x22FB12C")]
		public EventTypeReplaySaveInfo()
		{
		}
	}

	[Token(Token = "0x200038D")]
	public class EventTypeReplayPlayInfo : EventLoggerBase
	{
		[Token(Token = "0x400374F")]
		[FieldOffset(Offset = "0x18")]
		public uint match_mode;

		[Token(Token = "0x4003750")]
		[FieldOffset(Offset = "0x1C")]
		public uint game_mode;

		[Token(Token = "0x4003751")]
		[FieldOffset(Offset = "0x20")]
		public uint group_mode;

		[Token(Token = "0x4003752")]
		[FieldOffset(Offset = "0x24")]
		public uint map_id;

		[Token(Token = "0x4003753")]
		[FieldOffset(Offset = "0x28")]
		public ulong match_id;

		[Token(Token = "0x4003754")]
		[FieldOffset(Offset = "0x30")]
		public uint play_type;

		[Token(Token = "0x4003755")]
		[FieldOffset(Offset = "0x34")]
		public uint view_time;

		[Token(Token = "0x4003756")]
		[FieldOffset(Offset = "0x38")]
		public uint total_time;

		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x22FB368", Offset = "0x22FB368", VA = "0x22FB368")]
		public EventTypeReplayPlayInfo()
		{
		}
	}

	[Token(Token = "0x200038E")]
	public class EventTypeCupLobbyResult : EventLoggerBase
	{
		[Token(Token = "0x4003757")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x4003758")]
		[FieldOffset(Offset = "0x20")]
		public bool if_show;

		[Token(Token = "0x4003759")]
		[FieldOffset(Offset = "0x21")]
		public bool is_draw;

		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x22FB4FC", Offset = "0x22FB4FC", VA = "0x22FB4FC")]
		public EventTypeCupLobbyResult()
		{
		}
	}

	[Token(Token = "0x200038F")]
	public class EventTypeCDNTransferTrafficMonitor : EventLoggerBase
	{
		[Token(Token = "0x400375A")]
		[FieldOffset(Offset = "0x18")]
		public uint type;

		[Token(Token = "0x400375B")]
		[FieldOffset(Offset = "0x20")]
		public ulong transfer_size;

		[Token(Token = "0x400375C")]
		[FieldOffset(Offset = "0x28")]
		public uint transfer_time;

		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x22FBCB4", Offset = "0x22FBCB4", VA = "0x22FBCB4")]
		public EventTypeCDNTransferTrafficMonitor()
		{
		}
	}

	[Token(Token = "0x2000390")]
	public class EventTypeWorkshopSceneEdit : EventLoggerBase
	{
		[Token(Token = "0x2000391")]
		public class SaveErrorInfo
		{
			[Token(Token = "0x4003770")]
			[FieldOffset(Offset = "0x8")]
			public uint error_type;

			[Token(Token = "0x4003771")]
			[FieldOffset(Offset = "0xC")]
			public uint cnt;

			[Token(Token = "0x6000EFC")]
			[Address(RVA = "0x22FBB48", Offset = "0x22FBB48", VA = "0x22FBB48")]
			public SaveErrorInfo()
			{
			}
		}

		[Token(Token = "0x400375D")]
		[FieldOffset(Offset = "0x18")]
		public uint scene_edit_time;

		[Token(Token = "0x400375E")]
		[FieldOffset(Offset = "0x1C")]
		public uint close_shelf_cnt;

		[Token(Token = "0x400375F")]
		[FieldOffset(Offset = "0x20")]
		public uint close_shelf_time;

		[Token(Token = "0x4003760")]
		[FieldOffset(Offset = "0x24")]
		public uint change_camera_cnt;

		[Token(Token = "0x4003761")]
		[FieldOffset(Offset = "0x28")]
		public uint free_camera_time;

		[Token(Token = "0x4003762")]
		[FieldOffset(Offset = "0x2C")]
		public uint adjust_floor_up_times;

		[Token(Token = "0x4003763")]
		[FieldOffset(Offset = "0x30")]
		public uint adjust_floor_down_times;

		[Token(Token = "0x4003764")]
		[FieldOffset(Offset = "0x34")]
		public float adjust_floor_max_height;

		[Token(Token = "0x4003765")]
		[FieldOffset(Offset = "0x38")]
		public uint top_view_time;

		[Token(Token = "0x4003766")]
		[FieldOffset(Offset = "0x3C")]
		public uint top_view_cnt;

		[Token(Token = "0x4003767")]
		[FieldOffset(Offset = "0x40")]
		public uint max_grouped_cnt;

		[Token(Token = "0x4003768")]
		[FieldOffset(Offset = "0x44")]
		public uint slot_id;

		[Token(Token = "0x4003769")]
		[FieldOffset(Offset = "0x48")]
		public string workshop_code;

		[Token(Token = "0x400376A")]
		[FieldOffset(Offset = "0x4C")]
		public uint game_mode;

		[Token(Token = "0x400376B")]
		[FieldOffset(Offset = "0x50")]
		public uint debug_time;

		[Token(Token = "0x400376C")]
		[FieldOffset(Offset = "0x54")]
		public uint debug_cnt;

		[Token(Token = "0x400376D")]
		[FieldOffset(Offset = "0x58")]
		public uint save_cnt;

		[Token(Token = "0x400376E")]
		[FieldOffset(Offset = "0x5C")]
		public uint intersection_edit_time;

		[Token(Token = "0x400376F")]
		[FieldOffset(Offset = "0x60")]
		public List<SaveErrorInfo> save_error_infos;

		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x22FBABC", Offset = "0x22FBABC", VA = "0x22FBABC")]
		public EventTypeWorkshopSceneEdit()
		{
		}
	}

	[Token(Token = "0x2000392")]
	public class EventTypeUGCCustomModeMapContent : EventLoggerBase
	{
		[Token(Token = "0x2000393")]
		public class GraphInfo
		{
			[Token(Token = "0x4003779")]
			[FieldOffset(Offset = "0x8")]
			public int entity_type;

			[Token(Token = "0x400377A")]
			[FieldOffset(Offset = "0xC")]
			public string entity_id;

			[Token(Token = "0x400377B")]
			[FieldOffset(Offset = "0x10")]
			public string graph_id;

			[Token(Token = "0x6000EFF")]
			[Address(RVA = "0x22FEF50", Offset = "0x22FEF50", VA = "0x22FEF50")]
			public GraphInfo()
			{
			}
		}

		[Token(Token = "0x2000394")]
		public class BlockInfo
		{
			[Token(Token = "0x400377C")]
			[FieldOffset(Offset = "0x8")]
			public int block_id;

			[Token(Token = "0x400377D")]
			[FieldOffset(Offset = "0xC")]
			public int block_cnt;

			[Token(Token = "0x400377E")]
			[FieldOffset(Offset = "0x10")]
			public string graph_id;

			[Token(Token = "0x6000F00")]
			[Address(RVA = "0x22FEF48", Offset = "0x22FEF48", VA = "0x22FEF48")]
			public BlockInfo()
			{
			}
		}

		[Token(Token = "0x2000395")]
		public class HudInfo
		{
			[Token(Token = "0x400377F")]
			[FieldOffset(Offset = "0x8")]
			public uint hud_id;

			[Token(Token = "0x4003780")]
			[FieldOffset(Offset = "0xC")]
			public bool is_bind_graph;

			[Token(Token = "0x4003781")]
			[FieldOffset(Offset = "0x10")]
			public uint image_control_cnt;

			[Token(Token = "0x4003782")]
			[FieldOffset(Offset = "0x14")]
			public uint text_control_cnt;

			[Token(Token = "0x6000F01")]
			[Address(RVA = "0x22FEF58", Offset = "0x22FEF58", VA = "0x22FEF58")]
			public HudInfo()
			{
			}
		}

		[Token(Token = "0x2000396")]
		public enum ResourceType
		{
			[Token(Token = "0x4003784")]
			vfx = 1,
			[Token(Token = "0x4003785")]
			audio,
			[Token(Token = "0x4003786")]
			icon,
			[Token(Token = "0x4003787")]
			item,
			[Token(Token = "0x4003788")]
			ugcObject
		}

		[Token(Token = "0x2000397")]
		public class ResourceInfo
		{
			[Token(Token = "0x4003789")]
			[FieldOffset(Offset = "0x8")]
			public uint resource_type;

			[Token(Token = "0x400378A")]
			[FieldOffset(Offset = "0xC")]
			public string resource_id;

			[Token(Token = "0x400378B")]
			[FieldOffset(Offset = "0x10")]
			public uint resource_cnt;

			[Token(Token = "0x6000F02")]
			[Address(RVA = "0x22FEF60", Offset = "0x22FEF60", VA = "0x22FEF60")]
			public ResourceInfo()
			{
			}
		}

		[Token(Token = "0x4003772")]
		[FieldOffset(Offset = "0x18")]
		public uint slot_id;

		[Token(Token = "0x4003773")]
		[FieldOffset(Offset = "0x1C")]
		public string workshop_code;

		[Token(Token = "0x4003774")]
		[FieldOffset(Offset = "0x20")]
		public uint map_id;

		[Token(Token = "0x4003775")]
		[FieldOffset(Offset = "0x24")]
		public readonly List<GraphInfo> graph_infos;

		[Token(Token = "0x4003776")]
		[FieldOffset(Offset = "0x28")]
		public readonly List<BlockInfo> block_infos;

		[Token(Token = "0x4003777")]
		[FieldOffset(Offset = "0x2C")]
		public readonly List<HudInfo> hud_infos;

		[Token(Token = "0x4003778")]
		[FieldOffset(Offset = "0x30")]
		public readonly List<ResourceInfo> resource_infos;

		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x22FEC34", Offset = "0x22FEC34", VA = "0x22FEC34")]
		public EventTypeUGCCustomModeMapContent()
		{
		}

		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x22FED5C", Offset = "0x22FED5C", VA = "0x22FED5C")]
		public void AddResourceInfo(ResourceInfo info)
		{
		}
	}

	[Token(Token = "0x2000398")]
	public class EventTypeFreqSubscriptionTrigger : EventLoggerBase
	{
		[Token(Token = "0x400378C")]
		[FieldOffset(Offset = "0x18")]
		public uint subscription_source;

		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x22FEBBC", Offset = "0x22FEBBC", VA = "0x22FEBBC")]
		public EventTypeFreqSubscriptionTrigger()
		{
		}
	}

	[Token(Token = "0x2000399")]
	public class EventTypePlayerGameReconnect : EventLoggerBase
	{
		[Token(Token = "0x400378D")]
		[FieldOffset(Offset = "0x18")]
		public ulong match_id;

		[Token(Token = "0x400378E")]
		[FieldOffset(Offset = "0x20")]
		public bool is_reconnect;

		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0x24")]
		public uint reconnect_try_times;

		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0x28")]
		public ulong reconnect_time;

		[Token(Token = "0x4003791")]
		[FieldOffset(Offset = "0x30")]
		public bool reconnect_result;

		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x22FBE24", Offset = "0x22FBE24", VA = "0x22FBE24")]
		public EventTypePlayerGameReconnect()
		{
		}
	}

	[Token(Token = "0x200039A")]
	private sealed class _003CLogNavigate_003Ec__AnonStorey0
	{
		[Token(Token = "0x4003792")]
		[FieldOffset(Offset = "0x8")]
		internal string to;

		[Token(Token = "0x4003793")]
		[FieldOffset(Offset = "0xC")]
		internal string from;

		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x22F28B4", Offset = "0x22F28B4", VA = "0x22F28B4")]
		public _003CLogNavigate_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x22FE3C8", Offset = "0x22FE3C8", VA = "0x22FE3C8")]
		internal bool _003C_003Em__0(EventNavigateClick e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200039B")]
	private sealed class _003CLogClickByValue_003Ec__AnonStorey1
	{
		[Token(Token = "0x4003794")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x22F2D80", Offset = "0x22F2D80", VA = "0x22F2D80")]
		public _003CLogClickByValue_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x22FE324", Offset = "0x22FE324", VA = "0x22FE324")]
		internal bool _003C_003Em__0(ClickEntry e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200039C")]
	private sealed class _003CLogClick_003Ec__AnonStorey2
	{
		[Token(Token = "0x4003795")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x22F31C4", Offset = "0x22F31C4", VA = "0x22F31C4")]
		public _003CLogClick_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x22FE280", Offset = "0x22FE280", VA = "0x22FE280")]
		internal bool _003C_003Em__0(ClickEntry e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200039D")]
	private sealed class _003CLogUINavigationClose_003Ec__AnonStorey3
	{
		[Token(Token = "0x4003796")]
		[FieldOffset(Offset = "0x8")]
		internal string page_name;

		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x22F3558", Offset = "0x22F3558", VA = "0x22F3558")]
		public _003CLogUINavigationClose_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x22FE808", Offset = "0x22FE808", VA = "0x22FE808")]
		internal bool _003C_003Em__0(EventLogPageDetentionTimeItem e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200039E")]
	private sealed class _003CLogUGCMapDetailsPopup_003Ec__AnonStorey4
	{
		[Token(Token = "0x4003797")]
		[FieldOffset(Offset = "0x8")]
		internal uint scene;

		[Token(Token = "0x4003798")]
		[FieldOffset(Offset = "0xC")]
		internal string code;

		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x22F3E7C", Offset = "0x22F3E7C", VA = "0x22F3E7C")]
		public _003CLogUGCMapDetailsPopup_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x22FE750", Offset = "0x22FE750", VA = "0x22FE750")]
		internal bool _003C_003Em__0(EventTypeUGCMapDetailsPopup.ClickInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200039F")]
	private sealed class _003CLogPopupWindowClose_003Ec__AnonStorey5
	{
		[Token(Token = "0x4003799")]
		[FieldOffset(Offset = "0x8")]
		internal string windowName;

		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x22F42A4", Offset = "0x22F42A4", VA = "0x22F42A4")]
		public _003CLogPopupWindowClose_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x22FE608", Offset = "0x22FE608", VA = "0x22FE608")]
		internal bool _003C_003Em__0(EventTypePopupWindowViewTime.SinglePopupWindowViewTime e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003A0")]
	private sealed class _003CLogPopularUGCFirst_003Ec__AnonStorey6
	{
		[Token(Token = "0x400379A")]
		[FieldOffset(Offset = "0x8")]
		internal string workshopname;

		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x22F46B4", Offset = "0x22F46B4", VA = "0x22F46B4")]
		public _003CLogPopularUGCFirst_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x22FE564", Offset = "0x22FE564", VA = "0x22FE564")]
		internal bool _003C_003Em__0(EventPopularList e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003A1")]
	private sealed class _003CLogPopularUGC_003Ec__AnonStorey7
	{
		[Token(Token = "0x400379B")]
		[FieldOffset(Offset = "0x8")]
		internal string workshopname;

		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x22F4AD0", Offset = "0x22F4AD0", VA = "0x22F4AD0")]
		public _003CLogPopularUGC_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x22FE4C0", Offset = "0x22FE4C0", VA = "0x22FE4C0")]
		internal bool _003C_003Em__0(EventPopularList e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003A2")]
	private sealed class _003CLogWeekUGCFirst_003Ec__AnonStorey8
	{
		[Token(Token = "0x400379C")]
		[FieldOffset(Offset = "0x8")]
		internal string workshopname;

		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x22F4ED0", Offset = "0x22F4ED0", VA = "0x22F4ED0")]
		public _003CLogWeekUGCFirst_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x22FE950", Offset = "0x22FE950", VA = "0x22FE950")]
		internal bool _003C_003Em__0(EventWeekList e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003A3")]
	private sealed class _003CLogWeekUGC_003Ec__AnonStorey9
	{
		[Token(Token = "0x400379D")]
		[FieldOffset(Offset = "0x8")]
		internal string workshopname;

		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x22F52E4", Offset = "0x22F52E4", VA = "0x22F52E4")]
		public _003CLogWeekUGC_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x22FE8AC", Offset = "0x22FE8AC", VA = "0x22FE8AC")]
		internal bool _003C_003Em__0(EventWeekList e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003A4")]
	private sealed class _003CLogRecommendList_003Ec__AnonStoreyA
	{
		[Token(Token = "0x400379E")]
		[FieldOffset(Offset = "0x8")]
		internal string workshop_code;

		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x22F576C", Offset = "0x22F576C", VA = "0x22F576C")]
		public _003CLogRecommendList_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x22FE6AC", Offset = "0x22FE6AC", VA = "0x22FE6AC")]
		internal bool _003C_003Em__0(RecommendItemLog e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003A5")]
	private sealed class _003CLogBroadCastType_003Ec__AnonStoreyB
	{
		[Token(Token = "0x400379F")]
		[FieldOffset(Offset = "0x8")]
		internal EventBroadCastType type;

		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x22F5AF4", Offset = "0x22F5AF4", VA = "0x22F5AF4")]
		public _003CLogBroadCastType_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x22FE248", Offset = "0x22FE248", VA = "0x22FE248")]
		internal bool _003C_003Em__0(EventBroadCastEntry e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003A6")]
	private sealed class _003CCacheMallTabClick_003Ec__AnonStoreyC
	{
		[Token(Token = "0x40037A0")]
		[FieldOffset(Offset = "0x8")]
		internal uint mallType;

		[Token(Token = "0x40037A1")]
		[FieldOffset(Offset = "0xC")]
		internal string tabName;

		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x22F5E8C", Offset = "0x22F5E8C", VA = "0x22F5E8C")]
		public _003CCacheMallTabClick_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x22FE190", Offset = "0x22FE190", VA = "0x22FE190")]
		internal bool _003C_003Em__0(EventMallTabClickInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4003323")]
	public const string EVENT_TYPE_ADDFRIENDACTIVELY = "EventTypeAddFriendActively";

	[Token(Token = "0x4003324")]
	public const string EVENT_TYPE_DISCONNECTFROMNETWORK = "EventTypeDisconnectFromNetwork";

	[Token(Token = "0x4003325")]
	public const string EVENT_TYPE_GAME_LAG = "EventTypeGameLag";

	[Token(Token = "0x4003326")]
	public const string EVENT_TYPE_SHARE = "EventTypeShare";

	[Token(Token = "0x4003327")]
	public const string EVENT_TYPE_SHARE_LINK_RETURN = "EventTypeShareLinkReturn";

	[Token(Token = "0x4003328")]
	public const string EVENT_TYPE_IAP_RESULT = "EventTypeIAPResult";

	[Token(Token = "0x4003329")]
	public const string EVENT_TYPE_IAP_REBATE_RESULT = "EventTypeIAPRebateResult";

	[Token(Token = "0x400332A")]
	public const string EVENT_TYPE_REDEEM_REBATE_RESULT = "EventTypeRedeemRebateResult";

	[Token(Token = "0x400332B")]
	public const string EVENT_TYPE_SPLASHBANNER_GOTO = "EventTypeSplashBannerGoto";

	[Token(Token = "0x400332C")]
	public const string EVENT_TYPE_ANNIVERSARY_SPLASHBANNER_GOTO = "EventTypeLimitEventSplashBanner";

	[Token(Token = "0x400332D")]
	public const string EVENT_TYPE_OBSERVER_LOG = "EventTypeObserverLog";

	[Token(Token = "0x400332E")]
	public const string EVENT_TYPE_REPORT_CHEAT = "EventTypeReport";

	[Token(Token = "0x400332F")]
	public const string EVENT_TYPE_GACHA_OPEN = "EventTypeOpenGachaEntrance";

	[Token(Token = "0x4003330")]
	public const string EVENT_TYPE_GACHA_REWARDPOOL_OPEN = "EventTypeOpenRewardPoolCount";

	[Token(Token = "0x4003331")]
	public const string EVENT_TYPE_GIFT_RECEIVE = "EventTypeGiftReceive";

	[Token(Token = "0x4003332")]
	public const string EVENT_TYPE_CHAT = "EventTypeChat";

	[Token(Token = "0x4003333")]
	public const string EVENT_TYPE_BILLBOARD = "EventTypeBillboard";

	[Token(Token = "0x4003334")]
	public const string EVENT_TYPE_IAP_BUNDLE_PAYMENT = "EventTypeIAPBundlePayment";

	[Token(Token = "0x4003335")]
	public const string EVENT_TYPE_ELITE_PASS_SUBSCRIBE = "EventTypeElitePassSubscribe";

	[Token(Token = "0x4003336")]
	public const string EVENT_TYPE_SCAN_IAP_INVENTORY_RESULT = "EventTypeScanIAPInventoryResult";

	[Token(Token = "0x4003337")]
	public const string EVENT_TYPE_ANDROID_APPLICATION_DETECTION = "EventTypeAndroidApplicationDetection";

	[Token(Token = "0x4003338")]
	public const string EVENT_TYPE_NAVIGATION_CLICK_COUNT = "EventTypeNavigationClickCount";

	[Token(Token = "0x4003339")]
	public const string EVENT_TYPE_ENTER_GAME = "EventTypeEnterGame";

	[Token(Token = "0x400333A")]
	public const string EVENT_TYPE_LEAVE_GAME = "EventTypeLeaveGame";

	[Token(Token = "0x400333B")]
	public const string EVENT_TYPE_HIGH_FRAME_SWITCH = "EventTypeHighFrameSwitch";

	[Token(Token = "0x400333C")]
	public const string EVENT_TYPE_OPTIONALDOWNLOAD_INFO_LIST = "EventTypeOptionalDownloadInfoList";

	[Token(Token = "0x400333D")]
	public const string EVENT_TYPE_OPTIONALDOWNLOAD_OPERATION = "EventTypeOptionalDownloadOperation";

	[Token(Token = "0x400333E")]
	public const string EVENT_TYPE_GETAVATAR_BUNDLE = "EventTypeGetAvatarBundleClick";

	[Token(Token = "0x400333F")]
	public const string EVENT_TYPE_PROFILE_CLICK_COUNT = "EventTypeGotoOthersPersonalShowTimes";

	[Token(Token = "0x4003340")]
	public const string EVENT_TYPE_REWARDED_VIDEO_LOAD_LOG = "EventTypeRewardedVideoLoadLog";

	[Token(Token = "0x4003341")]
	public const string EVENT_TYPE_GROUPINVITE_SWITCH = "EventTypeGroupInviteOperation";

	[Token(Token = "0x4003342")]
	public const string EVENT_TYPE_ANO = "EventTypeANO";

	[Token(Token = "0x4003343")]
	public const string EVENT_TYPE_MALL_TAB_CLICK_COUNT = "EventTypeMallTabClickCount";

	[Token(Token = "0x4003344")]
	public const string EVENT_TYPE_INSTALLMENT_TAB_CLICK_COUNT = "EventTypeInstallmentClickCount";

	[Token(Token = "0x4003345")]
	public const string EVENT_TYPE_BACK_MALL_COUNT = "EventTypeBackMallCount";

	[Token(Token = "0x4003346")]
	public const string EVENT_TYPE_INGAME_TIPS = "EventTypeIngameTips";

	[Token(Token = "0x4003347")]
	public const string EVENT_TYPE_BASIC_SETTING = "EventTypeClientBasicSettingChange";

	[Token(Token = "0x4003348")]
	public const string EVENT_TYPE_MAX_SETTING = "EventTypeClientMaxSettingChange";

	[Token(Token = "0x4003349")]
	public const string EVENT_TYPE_OPERATION_SETTING = "EventTypeClientOperationSettingChange";

	[Token(Token = "0x400334A")]
	public const string EVENT_TYPE_IOS_IDFA = "EventTypeIOSIDFA";

	[Token(Token = "0x400334B")]
	public const string EVENT_TYPE_BACK_BTN_LOWERLEFT_CLICK = "EventTypeBackBTNLowerLeftClick";

	[Token(Token = "0x400334C")]
	public const string EVENT_TYPE_CHAMPIONSHIPCLIKC = "EventTypeChampionshipClick";

	[Token(Token = "0x400334D")]
	public const string EVENT_TYPE_LOGIN_VNLINK = "EventTypeLoginPageEntry";

	[Token(Token = "0x400334E")]
	public const string EVENT_TYPE_ENTER_WAITING_ISLAND = "EventTypeEnterWaitingIsland";

	[Token(Token = "0x400334F")]
	public const string EVENT_TYPE_LEAVE_WAITING_ISLAND = "EventTypeLeaveWaitingIsland";

	[Token(Token = "0x4003350")]
	public const string EVENT_TYPE_CLIENT_CLICK = "EventTypeClientClick";

	[Token(Token = "0x4003351")]
	public const string EVENT_TYPE_NAVIGATION_BATCH = "EventTypeNavigateBatch";

	[Token(Token = "0x4003352")]
	public const string EVENT_TYPE_CLIENTSETTING = "EventTypeClientSetting";

	[Token(Token = "0x4003353")]
	public const string EVENT_TYPE_REJECT_JOIN_GROUP = "EventTypeRejectJoinGroup";

	[Token(Token = "0x4003354")]
	public const string EVENT_TYPE_REJECT_GROUP_INVITE = "EventTypeRejectGroupInvite";

	[Token(Token = "0x4003355")]
	public const string EVENT_TYPE_NOTI_REPLACE = "EventTypeNotiWindowReplaced";

	[Token(Token = "0x4003356")]
	public const string EVENT_TYPE_GROUP_INVITE_WITHIN_CLIENT = "EventTypeGroupInviteWithinClient";

	[Token(Token = "0x4003357")]
	public const string EVENT_TYPE_DEFAULT_MUSIC_CLICK = "EventTypeDefaultMusicClick";

	[Token(Token = "0x4003358")]
	public const string EVENT_TYPE_RESERVATION_SENT = "EventTypeReservationSent";

	[Token(Token = "0x4003359")]
	public const string EVENT_TYPE_RESERVATION_REPLY = "EventTypeReservationReply";

	[Token(Token = "0x400335A")]
	public const string EVENT_TYPE_RESERVATION_CONFIRM = "EventTypeReservationConfirm";

	[Token(Token = "0x400335B")]
	public const string EVENT_TYPE_MALL_CLICK = "EventTypeShopClick";

	[Token(Token = "0x400335C")]
	public const string EVENT_TYPE_BANNER_CLICK = "EventTypeBannerClick";

	[Token(Token = "0x400335D")]
	public const string EVENT_TYPE_LIMITED_EVENT_SHARE = "EventTypeLimitedEventShare";

	[Token(Token = "0x400335E")]
	public const string EVENT_TYPE_FOURSYMBOLS_PICTURE_MATCHING = "EventTypeFourSymbolsPictureMatching";

	[Token(Token = "0x400335F")]
	public const string EVENT_TYPE_NAVI_PAGE_VIEW_TIME = "EventTypeNaviPageViewTime";

	[Token(Token = "0x4003360")]
	public const string EVENT_TYPE_PROFILEPAGE_VIEW_TIME = "EventTypeProfilePageViewTime";

	[Token(Token = "0x4003361")]
	public const string EVENT_TYPE_BOOYAH_EMOTE_EQUIP = "EventTypeBooyahEmoteEquip";

	[Token(Token = "0x4003362")]
	public const string EVENT_TYPE_BOOYAH_EMOTE_PLAY = "EventTypeBooyahEmotePlay";

	[Token(Token = "0x4003363")]
	public const string EVENT_TYPE_BIGEVENTSPLASH_PUSH = "EventTypeBigEventSplashPush";

	[Token(Token = "0x4003364")]
	public const string EVENT_TYPE_BROADCAST_TYPE_CNT = "EventTypeBroadCastTypeCnt";

	[Token(Token = "0x4003365")]
	public const string EVENT_TYPE_CLOSE_UP_SHARE = "EventTypeCloseUpShare";

	[Token(Token = "0x4003366")]
	public const string EVENT_TYPE_CLIENT_SETTING_CHANGE = "EventTypeClientSettingChange";

	[Token(Token = "0x4003367")]
	public const string EVENT_TYPE_FRIEND_RECOMMEND = "EventTypeFriendRecommend";

	[Token(Token = "0x4003368")]
	public const string EVENT_TYPE_BR_DEADINFO = "EventTypeBRDeadInfo";

	[Token(Token = "0x4003369")]
	public const string EVENT_TYPE_SYSTEM_SCREENSHOT = "EventTypeSystemScreenShot";

	[Token(Token = "0x400336A")]
	public const string EVENT_TYPE_MVPINFO = "EventTypeMVPInfo";

	[Token(Token = "0x400336B")]
	public const string EVENT_TYPE_BIGBANNERGOTO = "EventTypeBigBannerGoto";

	[Token(Token = "0x400336C")]
	public const string EVENT_TYPE_CSCUP_LOBBYRESULT = "EventTypeCupLobbyResult";

	[Token(Token = "0x400336D")]
	public const string EVENT_TYPE_REGISTER_INTITLE = "EventTypeRegisterIntitle";

	[Token(Token = "0x400336E")]
	public const string EVENT_TYPE_WORKSHOP_SCENEEDIT = "EventTypeWorkshopSceneEdit";

	[Token(Token = "0x400336F")]
	public const string EVENT_TYPE_UGC_CUSTOM_MODE_MAP_CONTENT = "EventTypeUGCCustomModeMapContent";

	[Token(Token = "0x4003370")]
	public const string EVENT_TYPE_CDN_TRANSFER_TRAFFICMONITOR = "EventTypeCDNTransferTrafficMonitor";

	[Token(Token = "0x4003371")]
	public const string EVENT_TYPE_PLAYER_GAME_RECONNECT = "EventTypePlayerGameReconnect";

	[Token(Token = "0x4003372")]
	public const string EVENT_TYPE_AutoPopupWindowCtrl = "EventTypeAutoPopupWindowCtrl";

	[Token(Token = "0x4003373")]
	public const string EVENT_TYPE_SPLASHBANNERPOPUP = "EventTypeSplashBannerPopup";

	[Token(Token = "0x4003374")]
	public const string EVENT_TYPE_PARTYGAME_SOLODANCE_BATTLE_CLICK_SUCCEED = "EventTypeFourthAnniversaryPartyBattleClicks";

	[Token(Token = "0x4003375")]
	public const string EVENT_TYPE_PARTYGAME_SOLODANCE_INVITATION_ACCEPT = "EventTypeFourthAnniversaryPartyBattleAccept";

	[Token(Token = "0x4003376")]
	public const string EVENT_TYPE_PARTYGAME_SOLODANCE_SEND_INVITATION = "EventTypeFourthAnniversaryPartyBattleInvite";

	[Token(Token = "0x4003377")]
	public const string EVENT_TYPE_PARTYGAME_SOLODANCE_BATTLE_ENTER = "EventTypeFourthAnniversaryPartyInBattle";

	[Token(Token = "0x4003378")]
	public const string EVENT_TYPE_PARTYGAME_SOLODANCE_BATTLE_FINISH = "EventTypeFourthAnniversaryPartyBattleFinish";

	[Token(Token = "0x4003379")]
	public const string EVENT_TYPE_MAX_QUALITY_ABTEST_SETTING = "EventTypeMaxQualityABTestSetting";

	[Token(Token = "0x400337A")]
	public const string EVENT_TYPE_GUIDE_TRIGGER = "EventTypeGuideTrigger";

	[Token(Token = "0x400337B")]
	public const string EVENT_TYPE_GUIDE_CLOSE_INFO = "EventTypeGuideCloseInfo";

	[Token(Token = "0x400337C")]
	public const string EVENT_TYPE_CUSTOMROOM_VOICECHAT = "EventTypeCustomRoomVoiceChat";

	[Token(Token = "0x400337D")]
	public const string EVENT_TYPE_OPTIONAL_BUNDLE_DOWNLOAD = "EventTypeOptionalBundleDownload";

	[Token(Token = "0x400337E")]
	public const string EVENT_TYPE_OPTIONAL_BUNDLE_DELETE = "EventTypeOptionalBundleDelete";

	[Token(Token = "0x400337F")]
	public const string EVENT_TYPE_HUD_SETTING_CHANGE = "EventTypeHUDSettingChange";

	[Token(Token = "0x4003380")]
	public const string EVENT_TYPE_BIGEVENT_CUMULATIVE_SIGNINDAYREWARD = "EventTypeBigEventCumulativeSigninDayReward";

	[Token(Token = "0x4003381")]
	public const string EVENT_TYPE_BRTUTORIAL_FORCEGUIDETRIGGER = "EventTypeBRTutorialForceGuideTrigger";

	[Token(Token = "0x4003382")]
	public const string EVENT_TYPE_FLASHSTORE_TABVIEWTIME = "EventTypeNaviTabViewTime";

	[Token(Token = "0x4003383")]
	public const string EVENT_TYPE_DIGITALUNIVERSEB_CONCERTSTATS = "EventTypeDigitalUniverseConcertStats";

	[Token(Token = "0x4003384")]
	public const string EVENT_TYPE_DIGITALUNIVERSEB_ROTATION = "EventTypeDigitalUniverseRotationStats";

	[Token(Token = "0x4003385")]
	public const string EVENT_TYPE_DIGITALUNIVERSEB_STARMAP_BEHAVIOR = "EventTypeDigitalUniverseStarMapBehavior";

	[Token(Token = "0x4003386")]
	public const string EVENT_TYPE_DIGITALUNIVERSEB_STARMAP_VALUE_CHANGE = "EventTypeDigitalUniverseStarMapValueChange";

	[Token(Token = "0x4003387")]
	public const string EVENT_TYPE_DIGITALUNIVERSEB_STARMAP_VALUE_REWARD = "EventTypeDigitalUniverseStarMapValueReward";

	[Token(Token = "0x4003388")]
	public const string EVENT_TYPE_MAX_LOBBY_YARD = "EventTypeMaxLobbyYard";

	[Token(Token = "0x4003389")]
	public const string EVENT_TYPE_TRAINING_LOCAL_GAME = "EventTypeTrainingLocalGame";

	[Token(Token = "0x400338A")]
	public const string EVENT_TYPE_WEREWOLVES_GAME = "EventTypeWereWolvesGame";

	[Token(Token = "0x400338B")]
	public const string EVENT_TYPE_LOCAL_NOTIFICATION_STATS = "EventTypeLocalNotificationStats";

	[Token(Token = "0x400338C")]
	public const string EVENT_TYPE_REPLAY_SETTING = "EventTypeReplaySetting";

	[Token(Token = "0x400338D")]
	public const string EVENT_TYPE_REPLAY_SAVE_STATS = "EventTypeReplaySaveStats";

	[Token(Token = "0x400338E")]
	public const string EVENT_TYPE_HIGHLIGHTS_TRIGGER = "EventTypeHighlightsTrigger";

	[Token(Token = "0x400338F")]
	public const string EVENT_TYPE_REPLAY_SAVE_INFO = "EventTypeReplaySaveInfo";

	[Token(Token = "0x4003390")]
	public const string EVENT_TYPE_REPLAY_PLAY_INFO = "EventTypeReplayPlayInfo";

	[Token(Token = "0x4003391")]
	public const string EVENT_TYPE_VETERAN_SPLASH_BANNER = "EventTypeVeteranSplashBanner";

	[Token(Token = "0x4003392")]
	public const string EVENT_TYPE_TUTORIAL_FORCE_GUIDE_PROCEDURE_INFO = "EventTypeTutorialForceGuideProcedureInfo";

	[Token(Token = "0x4003393")]
	public const string EVENT_TYPE_REGISTER_FORCE_GUIDE_TRIGGER = "EventTypeRegisterForceGuideTrigger";

	[Token(Token = "0x4003394")]
	public const string EVENT_TYPE_REGISTER_FORCE_GUIDE_COMPLETE = "EventTypeRegisterForceGuideComplete";

	[Token(Token = "0x4003395")]
	public const string EVENT_TYPE_AVATAR_SKILL_SLOT_GUIDE = "EventTypeAvatarSkillSlotGuide";

	[Token(Token = "0x4003396")]
	public const string EVENT_TYPE_CLIPBOARD_FEED_BACK = "EventTypeClipboardFeedback";

	[Token(Token = "0x4003397")]
	public const string EVENT_TYPE_UNIVERSAL_LINK_GOTO = "EventTypeUniversalLinkGoto";

	[Token(Token = "0x4003398")]
	public const string EVENT_TYPE_UGC_LOGIN_INFO = "EventTypeUGCLoginInfo";

	[Token(Token = "0x4003399")]
	public const string Event_Type_ClickWorkshopMapExposed = "EventTypeClickWorkshopMapExposed";

	[Token(Token = "0x400339A")]
	public const string EVENT_TYPE_CUP_LOGIN_ANIMATION = "EventTypeCupLoginAnimation";

	[Token(Token = "0x400339B")]
	public const string EVENT_TYPE_FULL_SCREEN_ANIMATION = "EventTypeFullScreenAnimation";

	[Token(Token = "0x400339C")]
	public const string EVENT_TYPE_GUEST_SAF_AUTHORIZATION = "EventTypeGuestAuthorization";

	[Token(Token = "0x400339D")]
	public const string EVENT_TYPE_BAN_VOICE = "EVENT_TYPE_BAN_VOICE";

	[Token(Token = "0x400339E")]
	public const string EVENT_TYPE_BANVOICE = "EventTypeBanVoice";

	[Token(Token = "0x400339F")]
	public const string EVENT_TYPE_POP_UP_WINDOW_VIEW_TIME = "EventTypePopupWindowViewTime";

	[Token(Token = "0x40033A0")]
	public const string EVENT_TYPE_RANKLEVEL_CHANGE = "EventTypeRankLevelChange";

	[Token(Token = "0x40033A1")]
	public const string EVENT_TYPE_FRIENDR_ECOMMEND_POP_UP = "EventTypeFriendRecommendPopup";

	[Token(Token = "0x40033A2")]
	public const string EVENT_TYPE_MVP_GROUP_INVITE_POP_UP = "EventTypeMvpGroupInvitePopup";

	[Token(Token = "0x40033A3")]
	public const string EVENT_TYPE_MAP_SELECTED = "EventTypeMapSelected";

	[Token(Token = "0x40033A4")]
	public const string EVENT_TYPE_UGC_MAP_DETAILS_POPUP = "EventTypeUGCMapDetailsPopup";

	[Token(Token = "0x40033A5")]
	[FieldOffset(Offset = "0x0")]
	private static EventClick eventClick;

	[Token(Token = "0x40033A6")]
	[FieldOffset(Offset = "0x4")]
	private static EventNavigate eventNavigation;

	[Token(Token = "0x40033A7")]
	[FieldOffset(Offset = "0x8")]
	private static EventNavigationClickCount eventNavigationClickCount;

	[Token(Token = "0x40033A8")]
	[FieldOffset(Offset = "0xC")]
	private static EventGotoOthersPersonalShowTimes eventGotoOthersPersonalShowTimes;

	[Token(Token = "0x40033A9")]
	[FieldOffset(Offset = "0x10")]
	private static EventBackMallCount eventBackMallCount;

	[Token(Token = "0x40033AA")]
	[FieldOffset(Offset = "0x14")]
	private static EventMallTabClickCount eventMallTabClickCount;

	[Token(Token = "0x40033AB")]
	[FieldOffset(Offset = "0x18")]
	private static EventBroadCastTypeCnt eventBroadCast;

	[Token(Token = "0x40033AC")]
	[FieldOffset(Offset = "0x1C")]
	private static EventTrainingLocalGame eventTrainingLocalGame;

	[Token(Token = "0x40033AD")]
	[FieldOffset(Offset = "0x20")]
	private static EventWereWolvesGame eventWereWolvesGame;

	[Token(Token = "0x40033AE")]
	[FieldOffset(Offset = "0x24")]
	private static EventLogPageDetentionTimeCached eventLogPageDetentionTimeCached;

	[Token(Token = "0x40033AF")]
	[FieldOffset(Offset = "0x28")]
	private static EventTypePopupWindowViewTime eventTypePopupWindowViewTimeCached;

	[Token(Token = "0x40033B0")]
	[FieldOffset(Offset = "0x2C")]
	private static EventCustomRoomVoiceChat eventCustomRoomVoiceChat;

	[Token(Token = "0x40033B1")]
	[FieldOffset(Offset = "0x30")]
	private static EventTypeClickWorkshopMapExposed eventtypeclickworkshpmapexposed;

	[Token(Token = "0x40033B2")]
	[FieldOffset(Offset = "0x34")]
	private static EventTypeOptionalBundleDownload eventTypeOptionalBundleDownload;

	[Token(Token = "0x40033B3")]
	[FieldOffset(Offset = "0x38")]
	private static EventTypetOptionalBundleDelete eventTypeOptionalBundleDelete;

	[Token(Token = "0x40033B4")]
	[FieldOffset(Offset = "0x3C")]
	private static EventTypeOptionalBundleDownload m_EventTypeOptionalBundleDownloadCache;

	[Token(Token = "0x40033B5")]
	[FieldOffset(Offset = "0x40")]
	private static EventTypeOptionalDownloadInfoList eventTypeOptionalDownloadInfoList;

	[Token(Token = "0x40033B6")]
	[FieldOffset(Offset = "0x44")]
	private static EventTypeUGCMapDetailsPopup eventTypeUGCMapDetailsPopup;

	[Token(Token = "0x40033B7")]
	[FieldOffset(Offset = "0x48")]
	private static EventTypeDigitalUniverseConcertStats m_EventTypeDigitalUniverseConcertStats;

	[Token(Token = "0x40033B8")]
	[FieldOffset(Offset = "0x4C")]
	public static EventReturnLobbyAfterDeath_RuntimeData EventReturnLobbyAfterDeathRuntimeData;

	[Token(Token = "0x40033B9")]
	[FieldOffset(Offset = "0x50")]
	public static EventOpOnBag_RuntimeData EventOpOnBagRuntimeData;

	[Token(Token = "0x40033BA")]
	[FieldOffset(Offset = "0x54")]
	public static EventWaitingForMatchmaking_RuntimeData EventWaitingForMatchmakingRuntimeData;

	[Token(Token = "0x40033BB")]
	[FieldOffset(Offset = "0x58")]
	public static EventAddFriendActively_RuntimeData EventAddFriendActivelyRuntimeData;

	[Token(Token = "0x40033BC")]
	[FieldOffset(Offset = "0x5C")]
	public static EventFPS_RuntimeData EventFPSRuntimeData;

	[Token(Token = "0x40033BD")]
	[FieldOffset(Offset = "0x60")]
	public static EventGameMemory_RuntimeData EventGameMemoryData;

	[Token(Token = "0x40033BE")]
	[FieldOffset(Offset = "0x64")]
	public static EventGameLag_RuntimeData EventGameLagData;

	[Token(Token = "0x40033BF")]
	[FieldOffset(Offset = "0x68")]
	public static EventObserverLog EventObserverLogData;

	[Token(Token = "0x40033C0")]
	[FieldOffset(Offset = "0x6C")]
	public static bool HasStartObserver;

	[Token(Token = "0x40033C1")]
	[FieldOffset(Offset = "0x70")]
	public static EventElitePassEntry EventElitePassEntryLog;

	[Token(Token = "0x40033C2")]
	[FieldOffset(Offset = "0x74")]
	public static EventClientPushSetting EventClientPushSettingData;

	[Token(Token = "0x40033C3")]
	[FieldOffset(Offset = "0x78")]
	public static EventTypeClientSettingChange EventClientSettingChange;

	[Token(Token = "0x40033C4")]
	[FieldOffset(Offset = "0x7C")]
	public static float LoadingStartTime;

	[Token(Token = "0x40033C5")]
	[FieldOffset(Offset = "0x80")]
	public static string Region;

	[Token(Token = "0x40033C6")]
	[FieldOffset(Offset = "0x88")]
	public static ulong UserID;

	[Token(Token = "0x40033C7")]
	[FieldOffset(Offset = "0x90")]
	public static EventEnterGame EnterGame;

	[Token(Token = "0x40033C8")]
	[FieldOffset(Offset = "0x94")]
	public static EventLeaveGame LeaveGame;

	[Token(Token = "0x40033C9")]
	[FieldOffset(Offset = "0x98")]
	public static EventEnterWaitingIsland EnterWaitingIsland;

	[Token(Token = "0x40033CA")]
	[FieldOffset(Offset = "0x9C")]
	public static EventLeaveWaitingIsland LeaveWaitingIsland;

	[Token(Token = "0x40033CB")]
	[FieldOffset(Offset = "0xA0")]
	public static EventIngameTips IngameTips;

	[Token(Token = "0x40033CC")]
	[FieldOffset(Offset = "0xA4")]
	private static uint ingameTipsOrginal;

	[Token(Token = "0x40033CD")]
	[FieldOffset(Offset = "0xA8")]
	public static IngameEnterGameData enterGameData;

	[Token(Token = "0x40033CE")]
	[FieldOffset(Offset = "0xAC")]
	public static EventBRDeadInfo EventBRDead;

	[Token(Token = "0x40033CF")]
	[FieldOffset(Offset = "0xB0")]
	private static int fpsIndex;

	[Token(Token = "0x40033D0")]
	[FieldOffset(Offset = "0xB4")]
	private static Action _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x40033D1")]
	[FieldOffset(Offset = "0xB8")]
	private static Predicate<EventLogPageDetentionTimeItem> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40033D2")]
	[FieldOffset(Offset = "0xBC")]
	private static Predicate<EventTypePopupWindowViewTime.SinglePopupWindowViewTime> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x22E3C74", Offset = "0x22E3C74", VA = "0x22E3C74")]
	public static void OnLogin()
	{
	}

	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x22E3CC0", Offset = "0x22E3CC0", VA = "0x22E3CC0")]
	public static void OnLogout()
	{
	}

	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x22E4A98", Offset = "0x22E4A98", VA = "0x22E4A98")]
	public static void SwitchObserver()
	{
	}

	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x22E4B98", Offset = "0x22E4B98", VA = "0x22E4B98")]
	public static void StartObserver(int mode)
	{
	}

	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0x22E4DA0", Offset = "0x22E4DA0", VA = "0x22E4DA0")]
	public static void ClickEndObserver()
	{
	}

	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x22E5514", Offset = "0x22E5514", VA = "0x22E5514")]
	public static void SendLogObserver()
	{
	}

	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x22E56BC", Offset = "0x22E56BC", VA = "0x22E56BC")]
	public static void LogSplashBannerGoto(uint id, string goto_url, uint goto_pos)
	{
	}

	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x22E5880", Offset = "0x22E5880", VA = "0x22E5880")]
	public static void LogAnniversaySplashBannerGoto(uint id, string goto_url, uint goto_pos)
	{
	}

	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x22E5A3C", Offset = "0x22E5A3C", VA = "0x22E5A3C")]
	public static void LogVeteranSplashBannerGoto(uint gopos)
	{
	}

	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0x22E5BB4", Offset = "0x22E5BB4", VA = "0x22E5BB4")]
	public static void LogAnniversaySplashBannerPush(uint event_id, uint entry_id, bool state)
	{
	}

	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0x22E5D74", Offset = "0x22E5D74", VA = "0x22E5D74")]
	public static void LogGroupInviteOperation(uint oper_type)
	{
	}

	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x22E5E88", Offset = "0x22E5E88", VA = "0x22E5E88")]
	public static void LogEventLoadingTimeUtilCloseMask(float currentTime)
	{
	}

	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x22E5F90", Offset = "0x22E5F90", VA = "0x22E5F90")]
	public static void LogEventLoadingTime(float currentTime)
	{
	}

	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x22E60D0", Offset = "0x22E60D0", VA = "0x22E60D0")]
	public static void LogEventWaitingForMatchmaking(float currentTime)
	{
	}

	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x22E6324", Offset = "0x22E6324", VA = "0x22E6324")]
	public static void LogAddFriendActively(ulong friend_account_id)
	{
	}

	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x22E651C", Offset = "0x22E651C", VA = "0x22E651C")]
	public static void LogBRTutorialLobbyGuide(bool guideWithMask)
	{
	}

	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x22E6630", Offset = "0x22E6630", VA = "0x22E6630")]
	public static void LogAddFriendActivelyAddFrom(ulong friend_account_id, string add_from)
	{
	}

	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x22E684C", Offset = "0x22E684C", VA = "0x22E684C")]
	public static void StartLogFPS(EventFPS_RuntimeData.FPSTrackingStep step, float gameTime, float duration)
	{
	}

	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x22E7290", Offset = "0x22E7290", VA = "0x22E7290")]
	public static void LogFPS(float currentTime, float fps)
	{
	}

	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x22E6A54", Offset = "0x22E6A54", VA = "0x22E6A54")]
	private static void SendFPSLog()
	{
	}

	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x22E78A4", Offset = "0x22E78A4", VA = "0x22E78A4")]
	public static void LogGameMemory(EGameTimeType _type)
	{
	}

	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x22E7B6C", Offset = "0x22E7B6C", VA = "0x22E7B6C")]
	private static void SendGameMemoryLog()
	{
	}

	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x22E7F98", Offset = "0x22E7F98", VA = "0x22E7F98")]
	public static void StartLogGameLag()
	{
	}

	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x22E825C", Offset = "0x22E825C", VA = "0x22E825C")]
	public static void SetGameItemMarkClickLog(DLPJLPIHNCL itemMarkType, LHBLJNHOPIJ pointType = LHBLJNHOPIJ.EItemMarkPointType_NB, bool isContainer = false)
	{
	}

	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x22E84E0", Offset = "0x22E84E0", VA = "0x22E84E0")]
	public static void SetGameItemMarkTypeLog(DLPJLPIHNCL itemMarkType, uint itemMarkId, bool isContainer = false)
	{
	}

	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x22E88EC", Offset = "0x22E88EC", VA = "0x22E88EC")]
	public static void SendGameLagLog()
	{
	}

	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x22E8EB0", Offset = "0x22E8EB0", VA = "0x22E8EB0")]
	public static void LogPing()
	{
	}

	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x22E975C", Offset = "0x22E975C", VA = "0x22E975C")]
	public static void LogBillboard(uint announcementId = 0u, uint activityId = 0u, string url = "")
	{
	}

	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x22E9A60", Offset = "0x22E9A60", VA = "0x22E9A60")]
	public static void LogDisconnectFromNetwork(EDisconnectionType disconnectionType)
	{
	}

	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x22E9FC4", Offset = "0x22E9FC4", VA = "0x22E9FC4")]
	public static void SendProfilePageViewTime()
	{
	}

	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x22E4F78", Offset = "0x22E4F78", VA = "0x22E4F78")]
	public static void SendEventLog(string eventType, EventLoggerBase payload)
	{
	}

	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x22EA010", Offset = "0x22EA010", VA = "0x22EA010")]
	public static void SendEventLogForDownloadOptional()
	{
	}

	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x22EA05C", Offset = "0x22EA05C", VA = "0x22EA05C")]
	public static void SendNetworkEventLog(string eventType, object payload)
	{
	}

	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x22EA3B4", Offset = "0x22EA3B4", VA = "0x22EA3B4")]
	private static string GetCurrentDateTime()
	{
		return null;
	}

	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x22EA4D4", Offset = "0x22EA4D4", VA = "0x22EA4D4")]
	public static EventLoginInfo LoginInfo()
	{
		return null;
	}

	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0x22EB13C", Offset = "0x22EB13C", VA = "0x22EB13C")]
	public static void LogIAPResult(string item_identifier, int error_code, string error_message, bool is_first_time, UINavigationUtil.UINavigationFrom ui_from)
	{
	}

	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0x22EB410", Offset = "0x22EB410", VA = "0x22EB410")]
	public static void LogScanIAPInventoryResult(ScanIAPInventoryResult[] results)
	{
	}

	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x22EB694", Offset = "0x22EB694", VA = "0x22EB694")]
	public static void LogShare(EventShare share)
	{
	}

	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x22EB76C", Offset = "0x22EB76C", VA = "0x22EB76C")]
	public static void LogShareLinkReturn(string url)
	{
	}

	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0x22EB880", Offset = "0x22EB880", VA = "0x22EB880")]
	public static void LogIAPRebate(int rebate_id, int remaining_days, int error_code, string error_message, UINavigationUtil.UINavigationFrom ui_from)
	{
	}

	[Token(Token = "0x6000DD3")]
	[Address(RVA = "0x22EBB54", Offset = "0x22EBB54", VA = "0x22EBB54")]
	public static void LogRedeemRebate(int rebate_id, int remaining_days, int redeem_amount, int error_code, string error_message)
	{
	}

	[Token(Token = "0x6000DD4")]
	[Address(RVA = "0x22EBE4C", Offset = "0x22EBE4C", VA = "0x22EBE4C")]
	public static void LogPlayerClimb(Vector3 pos, string trigger_tag)
	{
	}

	[Token(Token = "0x6000DD5")]
	[Address(RVA = "0x22EBEC0", Offset = "0x22EBEC0", VA = "0x22EBEC0")]
	public static void LogReportCheat(ulong cheater, uint reason, IHAAMHPPLMG cheaterPlayerID, [Optional] uint[] subReason, bool inGame = true, uint reporteeType = 4u)
	{
	}

	[Token(Token = "0x6000DD6")]
	[Address(RVA = "0x22ECC3C", Offset = "0x22ECC3C", VA = "0x22ECC3C")]
	public static void LogReportCheatInHistory(ulong cheater, uint reason, MatchStats stats, ulong matchID = 0uL, [Optional] uint[] subReason, uint reporteeType = 4u)
	{
	}

	[Token(Token = "0x6000DD7")]
	[Address(RVA = "0x22ED6A8", Offset = "0x22ED6A8", VA = "0x22ED6A8")]
	public static void LogMatchWeaponInfo(string skinIds)
	{
	}

	[Token(Token = "0x6000DD8")]
	[Address(RVA = "0x22ED6FC", Offset = "0x22ED6FC", VA = "0x22ED6FC")]
	public static void LogMatchWeaponEquip(uint wpId, uint skinId)
	{
	}

	[Token(Token = "0x6000DD9")]
	[Address(RVA = "0x22ED758", Offset = "0x22ED758", VA = "0x22ED758")]
	public static void LogBRMatchResult(uint pre_rank, uint pre_level, int pre_ranking_points, uint cur_rank, uint cur_level, int cur_ranking_points)
	{
	}

	[Token(Token = "0x6000DDA")]
	[Address(RVA = "0x22EDAD0", Offset = "0x22EDAD0", VA = "0x22EDAD0")]
	public static void LogOpenGacha()
	{
	}

	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0x22EDD10", Offset = "0x22EDD10", VA = "0x22EDD10")]
	public static void LogOpenGachaRewardPool()
	{
	}

	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x22EDF50", Offset = "0x22EDF50", VA = "0x22EDF50")]
	public static void SendChatEvent(EventChat eventChat)
	{
	}

	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x22EE080", Offset = "0x22EE080", VA = "0x22EE080")]
	public static void LogGiftReceive(uint itemId, uint expireTime)
	{
	}

	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x22EE304", Offset = "0x22EE304", VA = "0x22EE304")]
	public static void LogIAPBundlePurchase(int storeID, int bundleID, float priceUSD, int discount, int rebateID, string productIdentifier, UINavigationUtil.UINavigationFrom ui_from)
	{
	}

	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x22EE654", Offset = "0x22EE654", VA = "0x22EE654")]
	public static void LogElitePassSubscription(bool result, int rebateID, string productIdentifier, int errorCode, string price, UINavigationUtil.UINavigationFrom ui_from)
	{
	}

	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x22EE904", Offset = "0x22EE904", VA = "0x22EE904")]
	public static void LogAndroidApplicationDetection(List<int> installedIDs)
	{
	}

	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x22EEBD8", Offset = "0x22EEBD8", VA = "0x22EEBD8")]
	public static void LogChampionshipClick(ChampioshipClickType type, uint championshipType, uint championshipID)
	{
	}

	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x22EED40", Offset = "0x22EED40", VA = "0x22EED40")]
	public static void InitCacheLogSend()
	{
	}

	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x22E3DE8", Offset = "0x22E3DE8", VA = "0x22E3DE8")]
	private static void SendCachedLogs()
	{
	}

	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x22EEFA0", Offset = "0x22EEFA0", VA = "0x22EEFA0")]
	private static uint GetShadowOption()
	{
		return default(uint);
	}

	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x22EF120", Offset = "0x22EF120", VA = "0x22EF120")]
	public static void LogEnterGame()
	{
	}

	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x22EFBCC", Offset = "0x22EFBCC", VA = "0x22EFBCC")]
	private static void InitLeaveGameLog()
	{
	}

	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x22F05CC", Offset = "0x22F05CC", VA = "0x22F05CC")]
	public static void LogIOSIDFA(string open_id, string idfa)
	{
	}

	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x22F0700", Offset = "0x22F0700", VA = "0x22F0700")]
	public static void LogEnterBattery()
	{
	}

	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x22F07FC", Offset = "0x22F07FC", VA = "0x22F07FC")]
	public static void AddPetClickCnt()
	{
	}

	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x22F08FC", Offset = "0x22F08FC", VA = "0x22F08FC")]
	public static void AddPetId(int id)
	{
	}

	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x22F09E8", Offset = "0x22F09E8", VA = "0x22F09E8")]
	public static void LogClickMiniMapCnt()
	{
	}

	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x22F0AE8", Offset = "0x22F0AE8", VA = "0x22F0AE8")]
	public static void LogLeaveGame()
	{
	}

	[Token(Token = "0x6000DED")]
	[Address(RVA = "0x22F0DDC", Offset = "0x22F0DDC", VA = "0x22F0DDC")]
	public static void SendLogLeaveGame()
	{
	}

	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x22F0F0C", Offset = "0x22F0F0C", VA = "0x22F0F0C")]
	public static void LogHighFPSSwitch()
	{
	}

	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x22F10A0", Offset = "0x22F10A0", VA = "0x22F10A0")]
	public static void LogFlashStoreViewTime(UIFlashStoreNavigation.EventNaviTabViewTime eventTypeFlashStoreTabInfo)
	{
	}

	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x22F1180", Offset = "0x22F1180", VA = "0x22F1180")]
	public static void AddOptionalDownloadInfoToList(string package_name, ResDownloadType download_type, bool is_downloaded)
	{
	}

	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x22F14AC", Offset = "0x22F14AC", VA = "0x22F14AC")]
	public static void LogOptionalDownloadInfo()
	{
	}

	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x22F15CC", Offset = "0x22F15CC", VA = "0x22F15CC")]
	public static void LogIngameTutorialTrigger(uint id)
	{
	}

	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x22F16E0", Offset = "0x22F16E0", VA = "0x22F16E0")]
	public static void LogIngameTutorialCloseInfo(uint id, uint closeid)
	{
	}

	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x22F1814", Offset = "0x22F1814", VA = "0x22F1814")]
	public static void LogOptionalBundleDownload(uint bundle_id, string package_name, uint download_network_status, List<uint> download_type, string complete_result, string optional_version)
	{
	}

	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x22F1F18", Offset = "0x22F1F18", VA = "0x22F1F18")]
	public static void LogHudSettingChange(List<HudConfigItem> configs)
	{
	}

	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x22F229C", Offset = "0x22F229C", VA = "0x22F229C")]
	public static void LogOptionalBundleDelete(uint bundle_id, List<uint> download_type, string optional_version, bool delete_recommend)
	{
	}

	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x22F2440", Offset = "0x22F2440", VA = "0x22F2440")]
	public static void LogButtonPosLowerLeftClick()
	{
	}

	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x22F255C", Offset = "0x22F255C", VA = "0x22F255C")]
	public static void LogNavigate(string from, string to)
	{
	}

	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x22F2950", Offset = "0x22F2950", VA = "0x22F2950")]
	public static void LogClickByValue(ClickType clickType, uint value, string[] hierarchy)
	{
	}

	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0x22F2D98", Offset = "0x22F2D98", VA = "0x22F2D98")]
	public static void LogClick(ClickType clickType, string[] hierarchy)
	{
	}

	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0x22F31CC", Offset = "0x22F31CC", VA = "0x22F31CC")]
	public static void LogUINavigationClose(string page_name, int view_time)
	{
	}

	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x22F3570", Offset = "0x22F3570", VA = "0x22F3570")]
	public static void LogEventTypeDigitalUniverseConcertStats(ESingersBMiniGameLogType type)
	{
	}

	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x22F3980", Offset = "0x22F3980", VA = "0x22F3980")]
	public static void SendEventTypeDigitalUniverseConcertStats(bool isDrop)
	{
	}

	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x22F3AE4", Offset = "0x22F3AE4", VA = "0x22F3AE4")]
	public static void LogUGCMapDetailsPopup(uint scene, string code, ulong id)
	{
	}

	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x22F3F18", Offset = "0x22F3F18", VA = "0x22F3F18")]
	public static void LogPopupWindowClose(string windowName, int viewTime)
	{
	}

	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x22F42BC", Offset = "0x22F42BC", VA = "0x22F42BC")]
	public static void LogPopularUGCFirst(string workshopname)
	{
	}

	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x22F46CC", Offset = "0x22F46CC", VA = "0x22F46CC")]
	public static void LogPopularUGC(string workshopname)
	{
	}

	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x22F4AD8", Offset = "0x22F4AD8", VA = "0x22F4AD8")]
	public static void LogWeekUGCFirst(string workshopname)
	{
	}

	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x22F4EE0", Offset = "0x22F4EE0", VA = "0x22F4EE0")]
	public static void LogWeekUGC(string workshopname)
	{
	}

	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x22F52EC", Offset = "0x22F52EC", VA = "0x22F52EC")]
	public static void LogRecommendList(string workshop_code, bool click)
	{
	}

	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x22F577C", Offset = "0x22F577C", VA = "0x22F577C")]
	public static void LogBroadCastType(EventBroadCastType type)
	{
	}

	[Token(Token = "0x6000E06")]
	[Address(RVA = "0x22F5B0C", Offset = "0x22F5B0C", VA = "0x22F5B0C")]
	public static void CacheMallTabClick(uint mallType, string tabName)
	{
	}

	[Token(Token = "0x6000E07")]
	[Address(RVA = "0x22F5ECC", Offset = "0x22F5ECC", VA = "0x22F5ECC")]
	public static void CacheBackMall()
	{
	}

	[Token(Token = "0x6000E08")]
	[Address(RVA = "0x22F6074", Offset = "0x22F6074", VA = "0x22F6074")]
	public static void LogClickGetAvatarBtn(uint avatarID, bool isbundlebtn)
	{
	}

	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x22F61C0", Offset = "0x22F61C0", VA = "0x22F61C0")]
	public static void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x22F6448", Offset = "0x22F6448", VA = "0x22F6448")]
	public static void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x22F6594", Offset = "0x22F6594", VA = "0x22F6594")]
	public static void InitIngameTipsSetting(uint value)
	{
	}

	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x22F67AC", Offset = "0x22F67AC", VA = "0x22F67AC")]
	public static void LogIngameTipsSetting(uint value)
	{
	}

	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x22F6898", Offset = "0x22F6898", VA = "0x22F6898")]
	public static void SendIngameTipsSetting()
	{
	}

	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x22F69E4", Offset = "0x22F69E4", VA = "0x22F69E4")]
	public static void SendBasicSettingLog(EventSettingChangeLog log)
	{
	}

	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0x22F6B24", Offset = "0x22F6B24", VA = "0x22F6B24")]
	public static void SendMaxSettingLog(EventSettingChangeLog log)
	{
	}

	[Token(Token = "0x6000E10")]
	[Address(RVA = "0x22F6C64", Offset = "0x22F6C64", VA = "0x22F6C64")]
	public static void SendOperationSettingLog(EventSettingChangeLog log)
	{
	}

	[Token(Token = "0x6000E11")]
	[Address(RVA = "0x22F6DA4", Offset = "0x22F6DA4", VA = "0x22F6DA4")]
	public static void LogEnterWaitingIslandBattery()
	{
	}

	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x22F6EA0", Offset = "0x22F6EA0", VA = "0x22F6EA0")]
	public static void SendLogEnterWaitingIsland()
	{
	}

	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x22F74CC", Offset = "0x22F74CC", VA = "0x22F74CC")]
	public static void LogLeaveWaitingIslandBattleStarted(bool battleStarted)
	{
	}

	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x22F7270", Offset = "0x22F7270", VA = "0x22F7270")]
	private static void InitLogLeaveWaitingIsland()
	{
	}

	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x22F75B8", Offset = "0x22F75B8", VA = "0x22F75B8")]
	public static void SendLogLeaveWaitingIsland()
	{
	}

	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x22F7828", Offset = "0x22F7828", VA = "0x22F7828")]
	public static void LogLeaveWaitingIslandPing()
	{
	}

	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x22F7EAC", Offset = "0x22F7EAC", VA = "0x22F7EAC")]
	public static void LogClientPushSetting(bool is_first_login = false)
	{
	}

	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x22F8540", Offset = "0x22F8540", VA = "0x22F8540")]
	public static void LogClientSettingChange()
	{
	}

	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x22F8AFC", Offset = "0x22F8AFC", VA = "0x22F8AFC")]
	public static void LogBigBannerGoto(int gopos, string subgopos)
	{
	}

	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0x22F8C30", Offset = "0x22F8C30", VA = "0x22F8C30")]
	public static void LogFriendRecommend(RecommendFriendInfo recommendFriend, int choose)
	{
	}

	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0x22F8E9C", Offset = "0x22F8E9C", VA = "0x22F8E9C")]
	public static void LogLoginVNLinkClick()
	{
	}

	[Token(Token = "0x6000E1C")]
	[Address(RVA = "0x22F9008", Offset = "0x22F9008", VA = "0x22F9008")]
	public static void LogLoginVNLinkShow()
	{
	}

	[Token(Token = "0x6000E1D")]
	[Address(RVA = "0x22F916C", Offset = "0x22F916C", VA = "0x22F916C")]
	public static void LogMaxLobbyYardEditTime(int time)
	{
	}

	[Token(Token = "0x6000E1E")]
	[Address(RVA = "0x22F9280", Offset = "0x22F9280", VA = "0x22F9280")]
	public static EventTrainingLocalGame GetTrainingLocalGameInfo()
	{
		return null;
	}

	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0x22F9478", Offset = "0x22F9478", VA = "0x22F9478")]
	public static void SendTrainingLocalGameLog()
	{
	}

	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x22F95B4", Offset = "0x22F95B4", VA = "0x22F95B4")]
	public static void StartCustomRoomVoiceChat(tcp.RoomInfo info)
	{
	}

	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x22F98C4", Offset = "0x22F98C4", VA = "0x22F98C4")]
	public static void LogCustomRoomVoiceMicClick(uint micClick, uint hornClick)
	{
	}

	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x22F9A58", Offset = "0x22F9A58", VA = "0x22F9A58")]
	public static void SendCustomRoomVoiceChat(bool micOn, bool hornOn)
	{
	}

	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x22F9CB8", Offset = "0x22F9CB8", VA = "0x22F9CB8")]
	public static EventWereWolvesGame GetEventWereWolvesGame()
	{
		return null;
	}

	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x22F9E30", Offset = "0x22F9E30", VA = "0x22F9E30")]
	public static void SendWereWolvesGameLog()
	{
	}

	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x22F9FD0", Offset = "0x22F9FD0", VA = "0x22F9FD0")]
	public static void SendBRDeadInfo(int deadReason)
	{
	}

	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x22FA2BC", Offset = "0x22FA2BC", VA = "0x22FA2BC")]
	public static void OnSystemScreenShot()
	{
	}

	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x22FA6E0", Offset = "0x22FA6E0", VA = "0x22FA6E0")]
	public static void SendMVPInfoLog(uint rank, bool isMVP)
	{
	}

	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x22FA9F0", Offset = "0x22FA9F0", VA = "0x22FA9F0")]
	public static void SendRegisterCreateNameLog(ulong accountId, uint intitleTime)
	{
	}

	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x22FAB40", Offset = "0x22FAB40", VA = "0x22FAB40")]
	public static void SendReplaySaveStatsLog(bool success, uint match, uint game, uint group, byte rank)
	{
	}

	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x22FACD0", Offset = "0x22FACD0", VA = "0x22FACD0")]
	public static void SendHighlightsTriggerLog(uint match, uint game, uint group, uint map, ulong matchID, float time)
	{
	}

	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x22FAEB0", Offset = "0x22FAEB0", VA = "0x22FAEB0")]
	public static void SendReplaySaveInfoLog(uint match, uint game, uint group, uint map, ulong matchID, uint channel, bool highlight, float replayTime, float highlightTime, byte rank)
	{
	}

	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x22FB134", Offset = "0x22FB134", VA = "0x22FB134")]
	public static void SendReplayPlayInfoLog(uint match, uint game, uint group, uint map, ulong matchID, uint playType, float viewTime, float totalTime)
	{
	}

	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x22FB370", Offset = "0x22FB370", VA = "0x22FB370")]
	public static void SendCupLobbyResultLog(bool isShow, bool isDraw)
	{
	}

	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0x22FB504", Offset = "0x22FB504", VA = "0x22FB504")]
	public static void SendWorkshopSceneEditLog(uint totalTime, uint closeCnt, uint closeTime, uint editCnt, uint freeTime, uint adjustFloorUpCnt, uint adjustFloorDownCnt, float adjustFloorMaxHeight, uint topViewTime, uint topViewCnt, uint maxGroupedCnt, uint slot_id, string workshop_code, uint game_mode, uint debug_time, uint debug_cnt, uint saveCount, Dictionary<uint, uint> saveErrorInfos, uint intersectionEditTime)
	{
	}

	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x22FBB50", Offset = "0x22FBB50", VA = "0x22FBB50")]
	public static void SendCDNTransferTrafficMonitor(uint type, ulong transfer_size, uint transfer_time)
	{
	}

	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x22FBCBC", Offset = "0x22FBCBC", VA = "0x22FBCBC")]
	public static void SendPlayerGameReconnectLog(ulong matchId, uint reconnectTryTimes, ulong reconnectTime, bool reconnectResult)
	{
	}

	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x22FBE2C", Offset = "0x22FBE2C", VA = "0x22FBE2C")]
	public static void SendSplashBannerPopupLog(uint id)
	{
	}

	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x22FC00C", Offset = "0x22FC00C", VA = "0x22FC00C")]
	public static void SendLocalNotificationStats(EventLocalNotificationStats stats)
	{
	}

	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x22FC0E4", Offset = "0x22FC0E4", VA = "0x22FC0E4")]
	public static void SendPartyGameSoloDanceBattleClickSucceed(uint clickCount)
	{
	}

	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x22FC1F8", Offset = "0x22FC1F8", VA = "0x22FC1F8")]
	public static void SendPartyGameSoloDanceInvitationAccept()
	{
	}

	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x22FC2F0", Offset = "0x22FC2F0", VA = "0x22FC2F0")]
	public static void SendPartyGameSoloDanceSendInvitation(bool isFriend)
	{
	}

	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x22FC408", Offset = "0x22FC408", VA = "0x22FC408")]
	public static void SendEventTypeDefaultMusicClick(bool click)
	{
	}

	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x22FC51C", Offset = "0x22FC51C", VA = "0x22FC51C")]
	public static void SendEventTypeDigitalUniverseRotationStats(bool rotation)
	{
	}

	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x22FC630", Offset = "0x22FC630", VA = "0x22FC630")]
	public static void LogEventTypeDigitalUniverseStarMapBehavior(ulong behaviored_id, int type)
	{
	}

	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x22FC780", Offset = "0x22FC780", VA = "0x22FC780")]
	public static void LogEventTypeDigitalUniverseStarMapValueChange(int valueregion_id, ulong helped_id, uint cur_value, uint pre_value)
	{
	}

	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0x22FC908", Offset = "0x22FC908", VA = "0x22FC908")]
	public static void LogEventTypeDigitalUniverseStarMapValueReward(AwardDesc rewards, uint target_id)
	{
	}

	[Token(Token = "0x6000E3B")]
	[Address(RVA = "0x22FCA3C", Offset = "0x22FCA3C", VA = "0x22FCA3C")]
	public static void SendPartyGameSoloDanceBattleEnter()
	{
	}

	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0x22FCB34", Offset = "0x22FCB34", VA = "0x22FCB34")]
	public static void SendPartyGameSoloDanceBattleFinish()
	{
	}

	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x22FCC2C", Offset = "0x22FCC2C", VA = "0x22FCC2C")]
	public static void SendEventUniversalLinkGoto(string universal_link)
	{
	}

	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0x22FCD40", Offset = "0x22FCD40", VA = "0x22FCD40")]
	public static bool SendUGCLoginInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0x22FCFAC", Offset = "0x22FCFAC", VA = "0x22FCFAC")]
	public static void LogEventTypeCupLoginAnimation(uint cup_type, uint cup_id, bool is_click, uint animation_type)
	{
	}

	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x22FD124", Offset = "0x22FD124", VA = "0x22FD124")]
	public static void LogEventTypeFullScreenAnimation(FullscreenCgDesc cgDesc, uint lotteryID = 0u, uint lotterySubID = 0u, uint season = 0u, float playTime = 0f, float animTime = 0f, uint isPlayActively = 0u)
	{
	}

	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x22FD3EC", Offset = "0x22FD3EC", VA = "0x22FD3EC")]
	public static void LogEventGuestSAFPermission(int result)
	{
	}

	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x22FD500", Offset = "0x22FD500", VA = "0x22FD500")]
	public static void LogEventMapSelected(uint matchMode, uint gameMode, List<uint> mapIdList)
	{
	}

	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x22FD678", Offset = "0x22FD678", VA = "0x22FD678")]
	public static void LogEventTypeFriendRecommendPopup(ulong recommendAccountId, ERecommendPopupStatus status)
	{
	}

	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x22FD7C8", Offset = "0x22FD7C8", VA = "0x22FD7C8")]
	public static void LogEventTypeMvpGroupInvitePopup(ulong mvpAccountId, ERecommendPopupStatus status)
	{
	}

	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x22FD918", Offset = "0x22FD918", VA = "0x22FD918")]
	public static void LogMaxNewQualityABTest(uint groupID)
	{
	}

	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x22FE130", Offset = "0x22FE130", VA = "0x22FE130")]
	private static bool _003CSendCachedLogs_003Em__0(EventLogPageDetentionTimeItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x22FE160", Offset = "0x22FE160", VA = "0x22FE160")]
	private static bool _003CSendCachedLogs_003Em__1(EventTypePopupWindowViewTime.SinglePopupWindowViewTime item)
	{
		return default(bool);
	}
}
