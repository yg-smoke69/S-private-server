using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023AB")]
public class UIMatchResultRewardSingersBItemController : UIBaseController
{
	[Token(Token = "0x400DE1B")]
	[FieldOffset(Offset = "0x28")]
	private MatchResultRewardInfo m_Data;

	[Token(Token = "0x400DE1C")]
	[FieldOffset(Offset = "0x2C")]
	private UIMatchResultRewardSingersBItemView m_View;

	[Token(Token = "0x600C89C")]
	[Address(RVA = "0x281E250", Offset = "0x281E250", VA = "0x281E250")]
	public UIMatchResultRewardSingersBItemController()
	{
	}

	[Token(Token = "0x600C89D")]
	[Address(RVA = "0x281E2D4", Offset = "0x281E2D4", VA = "0x281E2D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C89E")]
	[Address(RVA = "0x281E37C", Offset = "0x281E37C", VA = "0x281E37C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C89F")]
	[Address(RVA = "0x281E438", Offset = "0x281E438", VA = "0x281E438", Slot = "31")]
	protected virtual UIStandardItemMAXBController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C8A0")]
	[Address(RVA = "0x281E530", Offset = "0x281E530", VA = "0x281E530")]
	public void SetViewData(object data)
	{
	}

	[Token(Token = "0x600C8A1")]
	[Address(RVA = "0x281E780", Offset = "0x281E780", VA = "0x281E780", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C8A2")]
	[Address(RVA = "0x281E7E4", Offset = "0x281E7E4", VA = "0x281E7E4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C8A3")]
	[Address(RVA = "0x281E848", Offset = "0x281E848", VA = "0x281E848", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C8A4")]
	[Address(RVA = "0x281E8AC", Offset = "0x281E8AC", VA = "0x281E8AC")]
	public void StopAllAni()
	{
	}

	[Token(Token = "0x600C8A5")]
	[Address(RVA = "0x281E900", Offset = "0x281E900", VA = "0x281E900")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C8A6")]
	[Address(RVA = "0x281E908", Offset = "0x281E908", VA = "0x281E908")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C8A7")]
	[Address(RVA = "0x281E910", Offset = "0x281E910", VA = "0x281E910")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C8A8")]
	[Address(RVA = "0x281E918", Offset = "0x281E918", VA = "0x281E918")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
