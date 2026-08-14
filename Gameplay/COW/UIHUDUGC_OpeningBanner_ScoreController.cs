using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002467")]
internal class UIHUDUGC_OpeningBanner_ScoreController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002468")]
	public class OpeningBanner_Score
	{
		[Token(Token = "0x400E211")]
		[FieldOffset(Offset = "0x8")]
		public int ShowTimeMs;

		[Token(Token = "0x600CF2D")]
		[Address(RVA = "0x2E230B4", Offset = "0x2E230B4", VA = "0x2E230B4")]
		public OpeningBanner_Score()
		{
		}
	}

	[Token(Token = "0x400E20E")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_OpeningBanner_ScoreView m_View;

	[Token(Token = "0x400E20F")]
	[FieldOffset(Offset = "0x2C")]
	private OpeningBanner_Score m_ViewData;

	[Token(Token = "0x400E210")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallID;

	[Token(Token = "0x600CF23")]
	[Address(RVA = "0x2E22EAC", Offset = "0x2E22EAC", VA = "0x2E22EAC")]
	public UIHUDUGC_OpeningBanner_ScoreController()
	{
	}

	[Token(Token = "0x600CF24")]
	[Address(RVA = "0x2E22F30", Offset = "0x2E22F30", VA = "0x2E22F30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF25")]
	[Address(RVA = "0x2E22FD4", Offset = "0x2E22FD4", VA = "0x2E22FD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF26")]
	[Address(RVA = "0x2E230BC", Offset = "0x2E230BC", VA = "0x2E230BC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CF27")]
	[Address(RVA = "0x2E231C4", Offset = "0x2E231C4", VA = "0x2E231C4")]
	public void SetStateByParams(bool isShow, List<FIMGICJHBNI> args)
	{
	}

	[Token(Token = "0x600CF28")]
	[Address(RVA = "0x2E233A8", Offset = "0x2E233A8", VA = "0x2E233A8")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600CF29")]
	[Address(RVA = "0x2E23538", Offset = "0x2E23538", VA = "0x2E23538", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF2A")]
	[Address(RVA = "0x2E23614", Offset = "0x2E23614", VA = "0x2E23614", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF2B")]
	[Address(RVA = "0x2E236E8", Offset = "0x2E236E8", VA = "0x2E236E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CF2C")]
	[Address(RVA = "0x2E236F0", Offset = "0x2E236F0", VA = "0x2E236F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
