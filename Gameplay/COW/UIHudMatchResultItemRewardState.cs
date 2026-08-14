using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002226")]
public class UIHudMatchResultItemRewardState : UIHudMatchResultStateBase
{
	[Token(Token = "0x400D529")]
	[FieldOffset(Offset = "0x14")]
	private List<BaseItemInfo> m_DebrisList;

	[Token(Token = "0x400D52A")]
	[FieldOffset(Offset = "0x18")]
	private List<BaseItemInfo> m_CommonList;

	[Token(Token = "0x400D52B")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D52C")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600B8F7")]
	[Address(RVA = "0x19B9DBC", Offset = "0x19B9DBC", VA = "0x19B9DBC")]
	public UIHudMatchResultItemRewardState(UIHudMatchResultStateMachine machine)
	{
	}

	[Token(Token = "0x600B8F8")]
	[Address(RVA = "0x19B9E70", Offset = "0x19B9E70", VA = "0x19B9E70", Slot = "5")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8F9")]
	[Address(RVA = "0x19B9EC8", Offset = "0x19B9EC8", VA = "0x19B9EC8", Slot = "6")]
	protected override bool OnEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8FA")]
	[Address(RVA = "0x19BA274", Offset = "0x19BA274", VA = "0x19BA274", Slot = "7")]
	protected override void OnFinish()
	{
	}

	[Token(Token = "0x600B8FB")]
	[Address(RVA = "0x19BA2F4", Offset = "0x19BA2F4", VA = "0x19BA2F4", Slot = "8")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x600B8FC")]
	[Address(RVA = "0x19BA3E8", Offset = "0x19BA3E8", VA = "0x19BA3E8")]
	private static CommonRewardItemInfo _003COnEnter_003Em__0(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x600B8FD")]
	[Address(RVA = "0x19BA3F0", Offset = "0x19BA3F0", VA = "0x19BA3F0")]
	private static CommonRewardItemInfo _003COnEnter_003Em__1(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x600B8FE")]
	[Address(RVA = "0x19BA3F8", Offset = "0x19BA3F8", VA = "0x19BA3F8")]
	public bool _003C_003EiFixBaseProxy_OnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8FF")]
	[Address(RVA = "0x19BA3FC", Offset = "0x19BA3FC", VA = "0x19BA3FC")]
	public bool _003C_003EiFixBaseProxy_OnEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600B900")]
	[Address(RVA = "0x19BA400", Offset = "0x19BA400", VA = "0x19BA400")]
	public void _003C_003EiFixBaseProxy_OnFinish()
	{
	}

	[Token(Token = "0x600B901")]
	[Address(RVA = "0x19BA404", Offset = "0x19BA404", VA = "0x19BA404")]
	public void _003C_003EiFixBaseProxy_OnExit()
	{
	}
}
