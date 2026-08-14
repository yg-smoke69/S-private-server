using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DB8")]
public class ChampionshipChannelDataManager : SingletonModule<ChampionshipChannelDataManager>
{
	[Token(Token = "0x2002DB9")]
	private sealed class _003CGetChannelDataByID_003Ec__AnonStorey0
	{
		[Token(Token = "0x40118B1")]
		[FieldOffset(Offset = "0x8")]
		internal int channelID;

		[Token(Token = "0x601323B")]
		[Address(RVA = "0x1722BF8", Offset = "0x1722BF8", VA = "0x1722BF8")]
		public _003CGetChannelDataByID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601323C")]
		[Address(RVA = "0x1722D28", Offset = "0x1722D28", VA = "0x1722D28")]
		internal bool _003C_003Em__0(ChampionshipChannelData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40118AE")]
	[FieldOffset(Offset = "0xC")]
	private ChampionshipChannelData m_DefaultChannel;

	[Token(Token = "0x40118AF")]
	[FieldOffset(Offset = "0x10")]
	private List<ChampionshipChannelData> m_ChannelList;

	[Token(Token = "0x40118B0")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<ChampionshipChannelData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700139A")]
	public ChampionshipChannelData DefaultChannel
	{
		[Token(Token = "0x6013235")]
		[Address(RVA = "0x1722820", Offset = "0x1722820", VA = "0x1722820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6013234")]
	[Address(RVA = "0x1722790", Offset = "0x1722790", VA = "0x1722790")]
	public ChampionshipChannelDataManager()
	{
	}

	[Token(Token = "0x6013236")]
	[Address(RVA = "0x1722878", Offset = "0x1722878", VA = "0x1722878", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013237")]
	[Address(RVA = "0x17228D4", Offset = "0x17228D4", VA = "0x17228D4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013238")]
	[Address(RVA = "0x1722AB4", Offset = "0x1722AB4", VA = "0x1722AB4")]
	public ChampionshipChannelData GetChannelDataByID(int channelID)
	{
		return null;
	}

	[Token(Token = "0x6013239")]
	[Address(RVA = "0x1722C00", Offset = "0x1722C00", VA = "0x1722C00")]
	public List<ChampionshipChannelData> GetChannelList()
	{
		return null;
	}

	[Token(Token = "0x601323A")]
	[Address(RVA = "0x1722C58", Offset = "0x1722C58", VA = "0x1722C58")]
	private static bool _003COnInit_003Em__0(ChampionshipChannelData e)
	{
		return default(bool);
	}
}
