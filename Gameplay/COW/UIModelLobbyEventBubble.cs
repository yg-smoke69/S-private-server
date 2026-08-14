using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030FC")]
public class UIModelLobbyEventBubble : UIBaseModel
{
	[Token(Token = "0x20030FD")]
	private sealed class _003CAddLobbyEventBubbleData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012A14")]
		[FieldOffset(Offset = "0x8")]
		internal LobbyEventType type;

		[Token(Token = "0x601487A")]
		[Address(RVA = "0x1AFF898", Offset = "0x1AFF898", VA = "0x1AFF898")]
		public _003CAddLobbyEventBubbleData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601487B")]
		[Address(RVA = "0x1AFFBD4", Offset = "0x1AFFBD4", VA = "0x1AFFBD4")]
		internal bool _003C_003Em__0(LobbyEventBubbleData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030FE")]
	private sealed class _003COnEventDataReady_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012A15")]
		[FieldOffset(Offset = "0x8")]
		internal LobbyEventType type;

		[Token(Token = "0x601487C")]
		[Address(RVA = "0x1AFFA20", Offset = "0x1AFFA20", VA = "0x1AFFA20")]
		public _003COnEventDataReady_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601487D")]
		[Address(RVA = "0x1AFFC44", Offset = "0x1AFFC44", VA = "0x1AFFC44")]
		internal bool _003C_003Em__0(uint x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030FF")]
	private sealed class _003CIsBubbleShowing_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012A16")]
		[FieldOffset(Offset = "0x8")]
		internal LobbyEventType lobbyEventType;

		[Token(Token = "0x601487E")]
		[Address(RVA = "0x1AFFBBC", Offset = "0x1AFFBBC", VA = "0x1AFFBBC")]
		public _003CIsBubbleShowing_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601487F")]
		[Address(RVA = "0x1AFFC0C", Offset = "0x1AFFC0C", VA = "0x1AFFC0C")]
		internal bool _003C_003Em__0(LobbyEventBubbleData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012A12")]
	[FieldOffset(Offset = "0xC")]
	private List<LobbyEventBubbleData> m_EventBubbleList;

	[Token(Token = "0x4012A13")]
	[FieldOffset(Offset = "0x10")]
	private List<uint> m_DataReadyList;

	[Token(Token = "0x601486E")]
	[Address(RVA = "0x1AFF290", Offset = "0x1AFF290", VA = "0x1AFF290")]
	public UIModelLobbyEventBubble()
	{
	}

	[Token(Token = "0x601486F")]
	[Address(RVA = "0x1AFF37C", Offset = "0x1AFF37C", VA = "0x1AFF37C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014870")]
	[Address(RVA = "0x1AFF3D4", Offset = "0x1AFF3D4", VA = "0x1AFF3D4", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014871")]
	[Address(RVA = "0x1AFF438", Offset = "0x1AFF438", VA = "0x1AFF438", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014872")]
	[Address(RVA = "0x1AFF4B0", Offset = "0x1AFF4B0", VA = "0x1AFF4B0")]
	public void ClearData()
	{
	}

	[Token(Token = "0x6014873")]
	[Address(RVA = "0x1AFF570", Offset = "0x1AFF570", VA = "0x1AFF570")]
	public List<LobbyEventBubbleData> GetEventBubbleList()
	{
		return null;
	}

	[Token(Token = "0x6014874")]
	[Address(RVA = "0x1AFF5C8", Offset = "0x1AFF5C8", VA = "0x1AFF5C8")]
	public List<uint> GetDataReadyList()
	{
		return null;
	}

	[Token(Token = "0x6014875")]
	[Address(RVA = "0x1AFF620", Offset = "0x1AFF620", VA = "0x1AFF620")]
	public bool AddLobbyEventBubbleData(LobbyEventType type, Func<bool> canShow, Func<bool> EventShowInContainer, Action resetBubble)
	{
		return default(bool);
	}

	[Token(Token = "0x6014876")]
	[Address(RVA = "0x1AFF8A0", Offset = "0x1AFF8A0", VA = "0x1AFF8A0")]
	public void OnEventDataReady(LobbyEventType type)
	{
	}

	[Token(Token = "0x6014877")]
	[Address(RVA = "0x1AFFA28", Offset = "0x1AFFA28", VA = "0x1AFFA28")]
	public bool IsBubbleShowing(LobbyEventType lobbyEventType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014878")]
	[Address(RVA = "0x1AFFBC4", Offset = "0x1AFFBC4", VA = "0x1AFFBC4")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014879")]
	[Address(RVA = "0x1AFFBCC", Offset = "0x1AFFBCC", VA = "0x1AFFBCC")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
