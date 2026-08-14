using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002CE6")]
public static class InteractionPopUtil
{
	[Token(Token = "0x2002CE7")]
	public enum UIInteractionPoptype
	{
		[Token(Token = "0x401121F")]
		None = 0,
		[Token(Token = "0x4011220")]
		LookInformation = 2,
		[Token(Token = "0x4011221")]
		AddFriends = 4,
		[Token(Token = "0x4011222")]
		InviteClan = 8,
		[Token(Token = "0x4011223")]
		GiftFriend = 0x10,
		[Token(Token = "0x4011224")]
		Whisper = 0x20,
		[Token(Token = "0x4011225")]
		TeamKickOut = 0x40,
		[Token(Token = "0x4011226")]
		ChampionshipTeam = 0x80,
		[Token(Token = "0x4011227")]
		InviteGroup = 0x100,
		[Token(Token = "0x4011228")]
		ApplyJoinGroup = 0x200,
		[Token(Token = "0x4011229")]
		DeleteFriend = 0x400,
		[Token(Token = "0x401122A")]
		AddToBlackList = 0x800,
		[Token(Token = "0x401122B")]
		GroupKickOut = 0x1000,
		[Token(Token = "0x401122C")]
		MarkFavorFriend = 0x2000,
		[Token(Token = "0x401122D")]
		CancleFavorFriend = 0x4000,
		[Token(Token = "0x401122E")]
		PlayerKick = 0x8000,
		[Token(Token = "0x401122F")]
		CreatorMoveTo = 0x10000,
		[Token(Token = "0x4011230")]
		CreatorMoveFrom = 0x20000,
		[Token(Token = "0x4011231")]
		PlayerMoveToObser = 0x40000,
		[Token(Token = "0x4011232")]
		PlayerMoveToPlay = 0x80000,
		[Token(Token = "0x4011233")]
		RoomLookInfo = 0x100000,
		[Token(Token = "0x4011234")]
		RoomAddFriend = 0x200000,
		[Token(Token = "0x4011235")]
		ReportChat = 0x400000,
		[Token(Token = "0x4011236")]
		CupTeamKickOut = 0x800000,
		[Token(Token = "0x4011237")]
		ExcludeSetFriendAlias = 0x1000000,
		[Token(Token = "0x4011238")]
		ReportVoice = 0x2000000,
		[Token(Token = "0x4011239")]
		Mute = 0x4000000,
		[Token(Token = "0x401123A")]
		UnMute = 0x8000000
	}

	[Token(Token = "0x2002CE8")]
	private sealed class _003CCreateInviteClan_003Ec__AnonStorey0
	{
		[Token(Token = "0x401123B")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6012CC9")]
		[Address(RVA = "0x1EDD604", Offset = "0x1EDD604", VA = "0x1EDD604")]
		public _003CCreateInviteClan_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012CCA")]
		[Address(RVA = "0x1EDD60C", Offset = "0x1EDD60C", VA = "0x1EDD60C")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CE9")]
	private sealed class _003CCreateLookInformation_003Ec__AnonStorey1
	{
		[Token(Token = "0x401123C")]
		[FieldOffset(Offset = "0x8")]
		internal UINavigationUtil.UINavigationFrom from;

		[Token(Token = "0x401123D")]
		[FieldOffset(Offset = "0x10")]
		internal ulong id;

		[Token(Token = "0x6012CCB")]
		[Address(RVA = "0x1EDE1C4", Offset = "0x1EDE1C4", VA = "0x1EDE1C4")]
		public _003CCreateLookInformation_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6012CCC")]
		[Address(RVA = "0x1EDE1CC", Offset = "0x1EDE1CC", VA = "0x1EDE1CC")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CEA")]
	private sealed class _003CCreateAddFriends_003Ec__AnonStorey2
	{
		[Token(Token = "0x401123E")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x401123F")]
		[FieldOffset(Offset = "0x10")]
		internal EFriendAddFrom add_from;

		[Token(Token = "0x4011240")]
		[FieldOffset(Offset = "0x14")]
		internal UINavigationUtil.UINavigationFrom from;

		[Token(Token = "0x6012CCD")]
		[Address(RVA = "0x2C82270", Offset = "0x2C82270", VA = "0x2C82270")]
		public _003CCreateAddFriends_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6012CCE")]
		[Address(RVA = "0x2C89160", Offset = "0x2C89160", VA = "0x2C89160")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CEB")]
	private sealed class _003CCreateMarkFavorFriend_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011241")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6012CCF")]
		[Address(RVA = "0x1EDE788", Offset = "0x1EDE788", VA = "0x1EDE788")]
		public _003CCreateMarkFavorFriend_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6012CD0")]
		[Address(RVA = "0x1EDE790", Offset = "0x1EDE790", VA = "0x1EDE790")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CEC")]
	private sealed class _003CCreateCancleFavorFriend_003Ec__AnonStorey4
	{
		[Token(Token = "0x4011242")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6012CD1")]
		[Address(RVA = "0x2C82750", Offset = "0x2C82750", VA = "0x2C82750")]
		public _003CCreateCancleFavorFriend_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6012CD2")]
		[Address(RVA = "0x2C89F94", Offset = "0x2C89F94", VA = "0x2C89F94")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CED")]
	private sealed class _003CCreateReportVoice_003Ec__AnonStorey5
	{
		[Token(Token = "0x4011243")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6012CD3")]
		[Address(RVA = "0x1EDEEAC", Offset = "0x1EDEEAC", VA = "0x1EDEEAC")]
		public _003CCreateReportVoice_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6012CD4")]
		[Address(RVA = "0x1EDEEB4", Offset = "0x1EDEEB4", VA = "0x1EDEEB4")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CEE")]
	private sealed class _003CCreateMute_003Ec__AnonStorey6
	{
		[Token(Token = "0x4011244")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x4011245")]
		[FieldOffset(Offset = "0x10")]
		internal bool mute;

		[Token(Token = "0x6012CD5")]
		[Address(RVA = "0x1EDEA68", Offset = "0x1EDEA68", VA = "0x1EDEA68")]
		public _003CCreateMute_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6012CD6")]
		[Address(RVA = "0x1EDEA70", Offset = "0x1EDEA70", VA = "0x1EDEA70")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CEF")]
	private sealed class _003CCreateSetFriendAlias_003Ec__AnonStorey7
	{
		[Token(Token = "0x4011246")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6012CD7")]
		[Address(RVA = "0x1EDF1D4", Offset = "0x1EDF1D4", VA = "0x1EDF1D4")]
		public _003CCreateSetFriendAlias_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6012CD8")]
		[Address(RVA = "0x1EDF1DC", Offset = "0x1EDF1DC", VA = "0x1EDF1DC")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CF0")]
	private sealed class _003CCreateGiftFriend_003Ec__AnonStorey8
	{
		[Token(Token = "0x4011247")]
		[FieldOffset(Offset = "0x8")]
		internal FriendInfo friendInfo;

		[Token(Token = "0x6012CD9")]
		[Address(RVA = "0x1EDCF2C", Offset = "0x1EDCF2C", VA = "0x1EDCF2C")]
		public _003CCreateGiftFriend_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6012CDA")]
		[Address(RVA = "0x1EDCF34", Offset = "0x1EDCF34", VA = "0x1EDCF34")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CF1")]
	private sealed class _003CCreateGroupKickOut_003Ec__AnonStoreyA
	{
		[Token(Token = "0x2002CF2")]
		private sealed class _003CCreateGroupKickOut_003Ec__AnonStoreyB
		{
			[Token(Token = "0x401124A")]
			[FieldOffset(Offset = "0x8")]
			internal object e;

			[Token(Token = "0x401124B")]
			[FieldOffset(Offset = "0xC")]
			internal _003CCreateGroupKickOut_003Ec__AnonStoreyA _003C_003Ef__ref_002410;

			[Token(Token = "0x6012CDE")]
			[Address(RVA = "0x1EDD4F8", Offset = "0x1EDD4F8", VA = "0x1EDD4F8")]
			public _003CCreateGroupKickOut_003Ec__AnonStoreyB()
			{
			}

			[Token(Token = "0x6012CDF")]
			[Address(RVA = "0x1EDD500", Offset = "0x1EDD500", VA = "0x1EDD500")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x4011248")]
		[FieldOffset(Offset = "0x8")]
		internal object id;

		[Token(Token = "0x4011249")]
		[FieldOffset(Offset = "0xC")]
		internal string memberName;

		[Token(Token = "0x6012CDB")]
		[Address(RVA = "0x1EDD0A8", Offset = "0x1EDD0A8", VA = "0x1EDD0A8")]
		public _003CCreateGroupKickOut_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6012CDC")]
		[Address(RVA = "0x1EDD0B0", Offset = "0x1EDD0B0", VA = "0x1EDD0B0")]
		internal bool _003C_003Em__0(GroupMemberInfo temp)
		{
			return default(bool);
		}

		[Token(Token = "0x6012CDD")]
		[Address(RVA = "0x1EDD158", Offset = "0x1EDD158", VA = "0x1EDD158")]
		internal void _003C_003Em__1(object e)
		{
		}
	}

	[Token(Token = "0x2002CF3")]
	private sealed class _003CCreateCupTeamKickOut_003Ec__AnonStoreyC
	{
		[Token(Token = "0x2002CF4")]
		private sealed class _003CCreateCupTeamKickOut_003Ec__AnonStoreyD
		{
			[Token(Token = "0x401124D")]
			[FieldOffset(Offset = "0x8")]
			internal object e;

			[Token(Token = "0x401124E")]
			[FieldOffset(Offset = "0xC")]
			internal _003CCreateCupTeamKickOut_003Ec__AnonStoreyC _003C_003Ef__ref_002412;

			[Token(Token = "0x6012CE2")]
			[Address(RVA = "0x1EDC908", Offset = "0x1EDC908", VA = "0x1EDC908")]
			public _003CCreateCupTeamKickOut_003Ec__AnonStoreyD()
			{
			}

			[Token(Token = "0x6012CE3")]
			[Address(RVA = "0x1EDC910", Offset = "0x1EDC910", VA = "0x1EDC910")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x401124C")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x6012CE0")]
		[Address(RVA = "0x2C839F0", Offset = "0x2C839F0", VA = "0x2C839F0")]
		public _003CCreateCupTeamKickOut_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x6012CE1")]
		[Address(RVA = "0x2C8A918", Offset = "0x2C8A918", VA = "0x2C8A918")]
		internal void _003C_003Em__0(object e)
		{
		}
	}

	[Token(Token = "0x2002CF5")]
	private sealed class _003CCreateWhisper_003Ec__AnonStoreyE
	{
		[Token(Token = "0x401124F")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x4011250")]
		[FieldOffset(Offset = "0x10")]
		internal UINavigationUtil.UINavigationFrom from;

		[Token(Token = "0x6012CE4")]
		[Address(RVA = "0x1EDF4BC", Offset = "0x1EDF4BC", VA = "0x1EDF4BC")]
		public _003CCreateWhisper_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x6012CE5")]
		[Address(RVA = "0x1EDF4C4", Offset = "0x1EDF4C4", VA = "0x1EDF4C4")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CF6")]
	private sealed class _003CCreateChampionshipTeam_003Ec__AnonStoreyF
	{
		[Token(Token = "0x4011251")]
		[FieldOffset(Offset = "0x8")]
		internal UINavigationUtil.UINavigationFrom from;

		[Token(Token = "0x4011252")]
		[FieldOffset(Offset = "0xC")]
		internal uint championshipType;

		[Token(Token = "0x4011253")]
		[FieldOffset(Offset = "0x10")]
		internal ulong teamID;

		[Token(Token = "0x6012CE6")]
		[Address(RVA = "0x2C8436C", Offset = "0x2C8436C", VA = "0x2C8436C")]
		public _003CCreateChampionshipTeam_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x6012CE7")]
		[Address(RVA = "0x2C8A0D0", Offset = "0x2C8A0D0", VA = "0x2C8A0D0")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CF7")]
	private sealed class _003CCreateInviteGroup_003Ec__AnonStorey10
	{
		[Token(Token = "0x4011254")]
		[FieldOffset(Offset = "0x8")]
		internal InviteGroupPopMenuData data;

		[Token(Token = "0x4011255")]
		[FieldOffset(Offset = "0xC")]
		internal UINavigationUtil.UINavigationFrom from;

		[Token(Token = "0x6012CE8")]
		[Address(RVA = "0x1EDD7D0", Offset = "0x1EDD7D0", VA = "0x1EDD7D0")]
		public _003CCreateInviteGroup_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x6012CE9")]
		[Address(RVA = "0x1EDD7D8", Offset = "0x1EDD7D8", VA = "0x1EDD7D8")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CF8")]
	private sealed class _003CCreateApplyJoinGroup_003Ec__AnonStorey11
	{
		[Token(Token = "0x4011256")]
		[FieldOffset(Offset = "0x8")]
		internal MessageInfo msgInfo;

		[Token(Token = "0x4011257")]
		[FieldOffset(Offset = "0xC")]
		internal UINavigationUtil.UINavigationFrom from;

		[Token(Token = "0x6012CEA")]
		[Address(RVA = "0x2C84918", Offset = "0x2C84918", VA = "0x2C84918")]
		public _003CCreateApplyJoinGroup_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x6012CEB")]
		[Address(RVA = "0x2C89D4C", Offset = "0x2C89D4C", VA = "0x2C89D4C")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x2002CF9")]
	private sealed class _003CCreateDeleteFriendGroup_003Ec__AnonStorey12
	{
		[Token(Token = "0x4011258")]
		[FieldOffset(Offset = "0x8")]
		internal string info;

		[Token(Token = "0x4011259")]
		[FieldOffset(Offset = "0x10")]
		internal ulong id;

		[Token(Token = "0x6012CEC")]
		[Address(RVA = "0x1EDCA30", Offset = "0x1EDCA30", VA = "0x1EDCA30")]
		public _003CCreateDeleteFriendGroup_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x6012CED")]
		[Address(RVA = "0x1EDCA38", Offset = "0x1EDCA38", VA = "0x1EDCA38")]
		internal void _003C_003Em__0(object obj)
		{
		}

		[Token(Token = "0x6012CEE")]
		[Address(RVA = "0x1EDCD20", Offset = "0x1EDCD20", VA = "0x1EDCD20")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2002CFA")]
	private sealed class _003CCreateAddToBlackList_003Ec__AnonStorey13
	{
		[Token(Token = "0x401125A")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x401125B")]
		[FieldOffset(Offset = "0x10")]
		internal string nickName;

		[Token(Token = "0x6012CEF")]
		[Address(RVA = "0x2C851BC", Offset = "0x2C851BC", VA = "0x2C851BC")]
		public _003CCreateAddToBlackList_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x6012CF0")]
		[Address(RVA = "0x2C89640", Offset = "0x2C89640", VA = "0x2C89640")]
		internal void _003C_003Em__0(object obj)
		{
		}

		[Token(Token = "0x6012CF1")]
		[Address(RVA = "0x2C89C50", Offset = "0x2C89C50", VA = "0x2C89C50")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2002CFB")]
	private sealed class _003CCreateCreatorMoveTo_003Ec__AnonStorey15
	{
		[Token(Token = "0x2002CFC")]
		private sealed class _003CCreateCreatorMoveTo_003Ec__AnonStorey16
		{
			[Token(Token = "0x401125D")]
			[FieldOffset(Offset = "0x8")]
			internal int from;

			[Token(Token = "0x401125E")]
			[FieldOffset(Offset = "0xC")]
			internal int to;

			[Token(Token = "0x401125F")]
			[FieldOffset(Offset = "0x10")]
			internal _003CCreateCreatorMoveTo_003Ec__AnonStorey15 _003C_003Ef__ref_002421;

			[Token(Token = "0x6012CF4")]
			[Address(RVA = "0x2C8A7A4", Offset = "0x2C8A7A4", VA = "0x2C8A7A4")]
			public _003CCreateCreatorMoveTo_003Ec__AnonStorey16()
			{
			}

			[Token(Token = "0x6012CF5")]
			[Address(RVA = "0x2C8A7AC", Offset = "0x2C8A7AC", VA = "0x2C8A7AC")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x401125C")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelCustomRoom m_Model;

		[Token(Token = "0x6012CF2")]
		[Address(RVA = "0x2C85D94", Offset = "0x2C85D94", VA = "0x2C85D94")]
		public _003CCreateCreatorMoveTo_003Ec__AnonStorey15()
		{
		}

		[Token(Token = "0x6012CF3")]
		[Address(RVA = "0x2C8A1D8", Offset = "0x2C8A1D8", VA = "0x2C8A1D8")]
		internal void _003C_003Em__0(object e)
		{
		}
	}

	[Token(Token = "0x2002CFD")]
	private sealed class _003CCreateTeamKickOut_003Ec__AnonStorey9
	{
		[Token(Token = "0x4011260")]
		[FieldOffset(Offset = "0x8")]
		internal object e;

		[Token(Token = "0x6012CF6")]
		[Address(RVA = "0x1EDF3B0", Offset = "0x1EDF3B0", VA = "0x1EDF3B0")]
		public _003CCreateTeamKickOut_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6012CF7")]
		[Address(RVA = "0x1EDF3B8", Offset = "0x1EDF3B8", VA = "0x1EDF3B8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002CFE")]
	private sealed class _003CCreatePlayerKick_003Ec__AnonStorey14
	{
		[Token(Token = "0x4011261")]
		[FieldOffset(Offset = "0x8")]
		internal RoomPlayerInfo d;

		[Token(Token = "0x6012CF8")]
		[Address(RVA = "0x1EDED90", Offset = "0x1EDED90", VA = "0x1EDED90")]
		public _003CCreatePlayerKick_003Ec__AnonStorey14()
		{
		}

		[Token(Token = "0x6012CF9")]
		[Address(RVA = "0x1EDED98", Offset = "0x1EDED98", VA = "0x1EDED98")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4011218")]
	[FieldOffset(Offset = "0x0")]
	private static Action<object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011219")]
	[FieldOffset(Offset = "0x4")]
	private static Action<object> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x401121A")]
	[FieldOffset(Offset = "0x8")]
	private static Action<object> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x401121B")]
	[FieldOffset(Offset = "0xC")]
	private static Action<object> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x401121C")]
	[FieldOffset(Offset = "0x10")]
	private static Action<object> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x401121D")]
	[FieldOffset(Offset = "0x14")]
	private static Action<object> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x6012CA2")]
	[Address(RVA = "0x2C81488", Offset = "0x2C81488", VA = "0x2C81488")]
	public static CommonPopMenuData CreateInviteClan(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	[Token(Token = "0x6012CA3")]
	[Address(RVA = "0x2C816F4", Offset = "0x2C816F4", VA = "0x2C816F4")]
	public static void CheckAndLogInformation(UINavigationUtil.UINavigationFrom from, ulong id)
	{
	}

	[Token(Token = "0x6012CA4")]
	[Address(RVA = "0x2C81D44", Offset = "0x2C81D44", VA = "0x2C81D44")]
	public static CommonPopMenuData CreateLookInformation(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	[Token(Token = "0x6012CA5")]
	[Address(RVA = "0x2C81FC8", Offset = "0x2C81FC8", VA = "0x2C81FC8")]
	public static CommonPopMenuData CreateAddFriends(UINavigationUtil.UINavigationFrom from, ulong id, EFriendAddFrom add_from)
	{
		return null;
	}

	[Token(Token = "0x6012CA6")]
	[Address(RVA = "0x2C82278", Offset = "0x2C82278", VA = "0x2C82278")]
	public static CommonPopMenuData CreateMarkFavorFriend(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	[Token(Token = "0x6012CA7")]
	[Address(RVA = "0x2C824E4", Offset = "0x2C824E4", VA = "0x2C824E4")]
	public static CommonPopMenuData CreateCancleFavorFriend(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	[Token(Token = "0x6012CA8")]
	[Address(RVA = "0x2C82758", Offset = "0x2C82758", VA = "0x2C82758")]
	public static CommonPopMenuData CreateReportVoice(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	[Token(Token = "0x6012CA9")]
	[Address(RVA = "0x2C829C4", Offset = "0x2C829C4", VA = "0x2C829C4")]
	public static CommonPopMenuData CreateMute(UINavigationUtil.UINavigationFrom from, ulong id, bool mute)
	{
		return null;
	}

	[Token(Token = "0x6012CAA")]
	[Address(RVA = "0x2C82C70", Offset = "0x2C82C70", VA = "0x2C82C70")]
	public static CommonPopMenuData CreateSetFriendAlias(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	[Token(Token = "0x6012CAB")]
	[Address(RVA = "0x2C82EDC", Offset = "0x2C82EDC", VA = "0x2C82EDC")]
	public static CommonPopMenuData CreateGiftFriend(UINavigationUtil.UINavigationFrom from, FriendInfo friendInfo)
	{
		return null;
	}

	[Token(Token = "0x6012CAC")]
	[Address(RVA = "0x2C8313C", Offset = "0x2C8313C", VA = "0x2C8313C")]
	public static CommonPopMenuData CreateTeamKickOut(UINavigationUtil.UINavigationFrom from, object id)
	{
		return null;
	}

	[Token(Token = "0x6012CAD")]
	[Address(RVA = "0x2C833B4", Offset = "0x2C833B4", VA = "0x2C833B4")]
	public static CommonPopMenuData CreateGroupKickOut(UINavigationUtil.UINavigationFrom from, object id)
	{
		return null;
	}

	[Token(Token = "0x6012CAE")]
	[Address(RVA = "0x2C8376C", Offset = "0x2C8376C", VA = "0x2C8376C")]
	public static CommonPopMenuData CreateCupTeamKickOut(UINavigationUtil.UINavigationFrom from, object id, int key)
	{
		return null;
	}

	[Token(Token = "0x6012CAF")]
	[Address(RVA = "0x2C839F8", Offset = "0x2C839F8", VA = "0x2C839F8")]
	public static CommonPopMenuData CreateWhisper(UINavigationUtil.UINavigationFrom from, ulong id)
	{
		return null;
	}

	[Token(Token = "0x6012CB0")]
	[Address(RVA = "0x2C83C84", Offset = "0x2C83C84", VA = "0x2C83C84")]
	public static CommonPopMenuData CreateReportChat(object message)
	{
		return null;
	}

	[Token(Token = "0x6012CB1")]
	[Address(RVA = "0x2C840CC", Offset = "0x2C840CC", VA = "0x2C840CC")]
	public static CommonPopMenuData CreateChampionshipTeam(UINavigationUtil.UINavigationFrom from, ulong teamID, uint championshipType)
	{
		return null;
	}

	[Token(Token = "0x6012CB2")]
	[Address(RVA = "0x2C84374", Offset = "0x2C84374", VA = "0x2C84374")]
	public static CommonPopMenuData CreateInviteGroup(UINavigationUtil.UINavigationFrom from, MessageInfo msgInfo)
	{
		return null;
	}

	[Token(Token = "0x6012CB3")]
	[Address(RVA = "0x2C846A0", Offset = "0x2C846A0", VA = "0x2C846A0")]
	public static CommonPopMenuData CreateApplyJoinGroup(UINavigationUtil.UINavigationFrom from, MessageInfo msgInfo)
	{
		return null;
	}

	[Token(Token = "0x6012CB4")]
	[Address(RVA = "0x2C84920", Offset = "0x2C84920", VA = "0x2C84920")]
	public static CommonPopMenuData CreateDeleteFriendGroup(UINavigationUtil.UINavigationFrom from, ulong id, string nickName)
	{
		return null;
	}

	[Token(Token = "0x6012CB5")]
	[Address(RVA = "0x2C84F2C", Offset = "0x2C84F2C", VA = "0x2C84F2C")]
	public static CommonPopMenuData CreateAddToBlackList(UINavigationUtil.UINavigationFrom from, ulong id, string nickName)
	{
		return null;
	}

	[Token(Token = "0x6012CB6")]
	[Address(RVA = "0x2C851C4", Offset = "0x2C851C4", VA = "0x2C851C4")]
	public static CommonPopMenuData CreatePlayerKick(RoomPlayerInfo m_info)
	{
		return null;
	}

	[Token(Token = "0x6012CB7")]
	[Address(RVA = "0x2C8541C", Offset = "0x2C8541C", VA = "0x2C8541C")]
	public static CommonPopMenuData CreatePlayerMoveToObser(RoomPlayerInfo m_info)
	{
		return null;
	}

	[Token(Token = "0x6012CB8")]
	[Address(RVA = "0x2C85674", Offset = "0x2C85674", VA = "0x2C85674")]
	public static CommonPopMenuData CreatePlayerMoveToPlay(RoomPlayerInfo m_info)
	{
		return null;
	}

	[Token(Token = "0x6012CB9")]
	[Address(RVA = "0x2C858CC", Offset = "0x2C858CC", VA = "0x2C858CC")]
	private static bool SwitchValidCheck(int from, int to, UIModelCustomRoom m_Model)
	{
		return default(bool);
	}

	[Token(Token = "0x6012CBA")]
	[Address(RVA = "0x2C85A98", Offset = "0x2C85A98", VA = "0x2C85A98")]
	public static CommonPopMenuData CreateCreatorMoveTo(int team_index)
	{
		return null;
	}

	[Token(Token = "0x6012CBB")]
	[Address(RVA = "0x2C85D9C", Offset = "0x2C85D9C", VA = "0x2C85D9C")]
	public static CommonPopMenuData CreateCreatorMoveFrom(int team_index)
	{
		return null;
	}

	[Token(Token = "0x6012CBC")]
	[Address(RVA = "0x2C86010", Offset = "0x2C86010", VA = "0x2C86010")]
	public static void OpenBriefBox(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, BaseProfileInfo info)
	{
	}

	[Token(Token = "0x6012CBD")]
	[Address(RVA = "0x2C86120", Offset = "0x2C86120", VA = "0x2C86120")]
	public static void OpenBriefBox(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, BaseProfileInfo info, Vector3 pos)
	{
	}

	[Token(Token = "0x6012CBE")]
	[Address(RVA = "0x2C877E0", Offset = "0x2C877E0", VA = "0x2C877E0")]
	public static void OpenBriefBox(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, ulong userprofileid, Vector3 pos)
	{
	}

	[Token(Token = "0x6012CBF")]
	[Address(RVA = "0x2C87B6C", Offset = "0x2C87B6C", VA = "0x2C87B6C")]
	public static void OpenBriefBox(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, ulong userprofileid)
	{
	}

	[Token(Token = "0x6012CC0")]
	[Address(RVA = "0x2C87C8C", Offset = "0x2C87C8C", VA = "0x2C87C8C")]
	public static void OpenCommonInteractionPanel(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, ulong userprofileid, Vector3 pos)
	{
	}

	[Token(Token = "0x6012CC1")]
	[Address(RVA = "0x2C87F88", Offset = "0x2C87F88", VA = "0x2C87F88")]
	public static void OpenCommonInteractionPanel(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, ulong userprofileid = 0uL)
	{
	}

	[Token(Token = "0x6012CC2")]
	[Address(RVA = "0x2C863E8", Offset = "0x2C863E8", VA = "0x2C863E8")]
	public static List<CommonPopMenuData> CreateCommonInteractionMenuList(UINavigationUtil.UINavigationFrom from, object data, UIInteractionPoptype PopType, ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6012CC3")]
	[Address(RVA = "0x2C880A8", Offset = "0x2C880A8", VA = "0x2C880A8")]
	private static void _003CCreateTeamKickOut_003Em__0(object e)
	{
	}

	[Token(Token = "0x6012CC4")]
	[Address(RVA = "0x2C883C8", Offset = "0x2C883C8", VA = "0x2C883C8")]
	private static void _003CCreateReportChat_003Em__1(object obj)
	{
	}

	[Token(Token = "0x6012CC5")]
	[Address(RVA = "0x2C884FC", Offset = "0x2C884FC", VA = "0x2C884FC")]
	private static void _003CCreatePlayerKick_003Em__2(object e)
	{
	}

	[Token(Token = "0x6012CC6")]
	[Address(RVA = "0x2C88AE0", Offset = "0x2C88AE0", VA = "0x2C88AE0")]
	private static void _003CCreatePlayerMoveToObser_003Em__3(object e)
	{
	}

	[Token(Token = "0x6012CC7")]
	[Address(RVA = "0x2C88C44", Offset = "0x2C88C44", VA = "0x2C88C44")]
	private static void _003CCreatePlayerMoveToPlay_003Em__4(object e)
	{
	}

	[Token(Token = "0x6012CC8")]
	[Address(RVA = "0x2C88FEC", Offset = "0x2C88FEC", VA = "0x2C88FEC")]
	private static void _003CCreateCreatorMoveFrom_003Em__5(object e)
	{
	}
}
