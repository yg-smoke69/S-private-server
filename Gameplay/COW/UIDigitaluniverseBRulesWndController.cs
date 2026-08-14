using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EEF")]
internal class UIDigitaluniverseBRulesWndController : UICommonRulesPopupController
{
	[Token(Token = "0x400C2D8")]
	private const string STAR_MAP_RULE_TAB = "T_35_KK_DIGITALUNIVERSEB_STARMAP";

	[Token(Token = "0x400C2D9")]
	private const string STAR_MAP_RULE_CONTENT = "T_35_KK_DIGITALUNIVERSEB_RULE7_D";

	[Token(Token = "0x400C2DA")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<DigitaluniverseBStarCraftValueDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400C2DB")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<DigitaluniverseBStarCraftValueDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400C2DC")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<DigitaluniverseBStarCraftValueDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600971E")]
	[Address(RVA = "0x2F0B198", Offset = "0x2F0B198", VA = "0x2F0B198")]
	public UIDigitaluniverseBRulesWndController()
	{
	}

	[Token(Token = "0x600971F")]
	[Address(RVA = "0x2F0B1A0", Offset = "0x2F0B1A0", VA = "0x2F0B1A0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009720")]
	[Address(RVA = "0x2F0B248", Offset = "0x2F0B248", VA = "0x2F0B248")]
	private ELimitedEvent.EventID GetEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009721")]
	[Address(RVA = "0x2F0B2A0", Offset = "0x2F0B2A0", VA = "0x2F0B2A0", Slot = "48")]
	public override List<RuleMapping>[] GetSelfRules()
	{
		return null;
	}

	[Token(Token = "0x6009722")]
	[Address(RVA = "0x2F0BD00", Offset = "0x2F0BD00", VA = "0x2F0BD00", Slot = "50")]
	protected override void RuleSelectedCallback(RuleMapping rule)
	{
	}

	[Token(Token = "0x6009723")]
	[Address(RVA = "0x2F0C350", Offset = "0x2F0C350", VA = "0x2F0C350", Slot = "49")]
	public override UICommonRulesTabItemController GetTabItemContrller()
	{
		return null;
	}

	[Token(Token = "0x6009724")]
	[Address(RVA = "0x2F0C444", Offset = "0x2F0C444", VA = "0x2F0C444")]
	private static bool _003CRuleSelectedCallback_003Em__0(DigitaluniverseBStarCraftValueDesc value)
	{
		return default(bool);
	}

	[Token(Token = "0x6009725")]
	[Address(RVA = "0x2F0C474", Offset = "0x2F0C474", VA = "0x2F0C474")]
	private static bool _003CRuleSelectedCallback_003Em__1(DigitaluniverseBStarCraftValueDesc value)
	{
		return default(bool);
	}

	[Token(Token = "0x6009726")]
	[Address(RVA = "0x2F0C4A4", Offset = "0x2F0C4A4", VA = "0x2F0C4A4")]
	private static bool _003CRuleSelectedCallback_003Em__2(DigitaluniverseBStarCraftValueDesc value)
	{
		return default(bool);
	}

	[Token(Token = "0x6009727")]
	[Address(RVA = "0x2F0C4D4", Offset = "0x2F0C4D4", VA = "0x2F0C4D4")]
	public List<RuleMapping>[] _003C_003EiFixBaseProxy_GetSelfRules()
	{
		return null;
	}

	[Token(Token = "0x6009728")]
	[Address(RVA = "0x2F0C4DC", Offset = "0x2F0C4DC", VA = "0x2F0C4DC")]
	public void _003C_003EiFixBaseProxy_RuleSelectedCallback(RuleMapping P0)
	{
	}

	[Token(Token = "0x6009729")]
	[Address(RVA = "0x2F0C4E4", Offset = "0x2F0C4E4", VA = "0x2F0C4E4")]
	public UICommonRulesTabItemController _003C_003EiFixBaseProxy_GetTabItemContrller()
	{
		return null;
	}
}
