using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F99")]
internal class UIHudADSpaceHintController : UIBaseController
{
	[Token(Token = "0x2001F9A")]
	private sealed class _003CShowHint_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C655")]
		[FieldOffset(Offset = "0x8")]
		internal BINOCEMCJNE game;

		[Token(Token = "0x6009D53")]
		[Address(RVA = "0x163A6E0", Offset = "0x163A6E0", VA = "0x163A6E0")]
		public _003CShowHint_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009D54")]
		[Address(RVA = "0x163A728", Offset = "0x163A728", VA = "0x163A728")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C652")]
	[FieldOffset(Offset = "0x28")]
	private UIHudADSpaceHintView m_View;

	[Token(Token = "0x400C653")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_HideDelayCall;

	[Token(Token = "0x400C654")]
	[FieldOffset(Offset = "0x30")]
	private Queue<ADSHintStyle> showHintQueue;

	[Token(Token = "0x6009D47")]
	[Address(RVA = "0x1638CD4", Offset = "0x1638CD4", VA = "0x1638CD4")]
	public UIHudADSpaceHintController()
	{
	}

	[Token(Token = "0x6009D48")]
	[Address(RVA = "0x1638D8C", Offset = "0x1638D8C", VA = "0x1638D8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D49")]
	[Address(RVA = "0x1638E34", Offset = "0x1638E34", VA = "0x1638E34", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D4A")]
	[Address(RVA = "0x163910C", Offset = "0x163910C", VA = "0x163910C")]
	private void DeActiveAll()
	{
	}

	[Token(Token = "0x6009D4B")]
	[Address(RVA = "0x1639298", Offset = "0x1639298", VA = "0x1639298")]
	private void OnStart1v1InfoChange()
	{
	}

	[Token(Token = "0x6009D4C")]
	[Address(RVA = "0x1639580", Offset = "0x1639580", VA = "0x1639580")]
	private float DurationForADSHintStyle(ADSHintStyle style)
	{
		return default(float);
	}

	[Token(Token = "0x6009D4D")]
	[Address(RVA = "0x1639608", Offset = "0x1639608", VA = "0x1639608")]
	public void SetData(ADSHintStyle style)
	{
	}

	[Token(Token = "0x6009D4E")]
	[Address(RVA = "0x163A4F0", Offset = "0x163A4F0", VA = "0x163A4F0")]
	private void ShowNextHint()
	{
	}

	[Token(Token = "0x6009D4F")]
	[Address(RVA = "0x16397D8", Offset = "0x16397D8", VA = "0x16397D8")]
	private void ShowHint(ADSHintStyle hintStyle)
	{
	}

	[Token(Token = "0x6009D50")]
	[Address(RVA = "0x163A6E8", Offset = "0x163A6E8", VA = "0x163A6E8")]
	private void _003CSetData_003Em__0()
	{
	}

	[Token(Token = "0x6009D51")]
	[Address(RVA = "0x163A704", Offset = "0x163A704", VA = "0x163A704")]
	private void _003CShowNextHint_003Em__1()
	{
	}

	[Token(Token = "0x6009D52")]
	[Address(RVA = "0x163A720", Offset = "0x163A720", VA = "0x163A720")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
