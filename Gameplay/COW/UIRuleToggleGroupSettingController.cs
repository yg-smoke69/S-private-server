using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002314")]
internal class UIRuleToggleGroupSettingController : UIBaseController
{
	[Token(Token = "0x2002315")]
	private sealed class _003CUpdateTipsAnchor_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DACA")]
		[FieldOffset(Offset = "0x8")]
		internal UIRuleToggleGroupSettingController _0024this;

		[Token(Token = "0x400DACB")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DACC")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DACD")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010AC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C226")]
			[Address(RVA = "0x1426F04", Offset = "0x1426F04", VA = "0x1426F04", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010AD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C227")]
			[Address(RVA = "0x1426F0C", Offset = "0x1426F0C", VA = "0x1426F0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C224")]
		[Address(RVA = "0x1426A48", Offset = "0x1426A48", VA = "0x1426A48")]
		public _003CUpdateTipsAnchor_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C225")]
		[Address(RVA = "0x1426DC4", Offset = "0x1426DC4", VA = "0x1426DC4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C228")]
		[Address(RVA = "0x1426F14", Offset = "0x1426F14", VA = "0x1426F14", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C229")]
		[Address(RVA = "0x1426F28", Offset = "0x1426F28", VA = "0x1426F28", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DAC7")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleToggleSettingV2View m_View;

	[Token(Token = "0x400DAC8")]
	[FieldOffset(Offset = "0x2C")]
	public CToggleGroupData Data;

	[Token(Token = "0x400DAC9")]
	[FieldOffset(Offset = "0x30")]
	public UIModeEditGeneralComponentHelper GeneralHelper;

	[Token(Token = "0x600C214")]
	[Address(RVA = "0x142644C", Offset = "0x142644C", VA = "0x142644C")]
	public UIRuleToggleGroupSettingController()
	{
	}

	[Token(Token = "0x600C215")]
	[Address(RVA = "0x14264D0", Offset = "0x14264D0", VA = "0x14264D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C216")]
	[Address(RVA = "0x1426578", Offset = "0x1426578", VA = "0x1426578", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C217")]
	[Address(RVA = "0x1426634", Offset = "0x1426634", VA = "0x1426634", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C218")]
	[Address(RVA = "0x1426698", Offset = "0x1426698", VA = "0x1426698", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C219")]
	[Address(RVA = "0x14266FC", Offset = "0x14266FC", VA = "0x14266FC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C21A")]
	[Address(RVA = "0x1423E5C", Offset = "0x1423E5C", VA = "0x1423E5C")]
	public void SetViewData(CToggleGroupData data, float width)
	{
	}

	[Token(Token = "0x600C21B")]
	[Address(RVA = "0x142697C", Offset = "0x142697C", VA = "0x142697C")]
	private IEnumerator UpdateTipsAnchor()
	{
		return null;
	}

	[Token(Token = "0x600C21C")]
	[Address(RVA = "0x1426A50", Offset = "0x1426A50", VA = "0x1426A50")]
	private void OnToggle(UIToggleButton btn)
	{
	}

	[Token(Token = "0x600C21D")]
	[Address(RVA = "0x1426C68", Offset = "0x1426C68", VA = "0x1426C68")]
	private void SetValue(int newValue)
	{
	}

	[Token(Token = "0x600C21E")]
	[Address(RVA = "0x1426780", Offset = "0x1426780", VA = "0x1426780")]
	private void OnValueChanged()
	{
	}

	[Token(Token = "0x600C21F")]
	[Address(RVA = "0x1426D80", Offset = "0x1426D80", VA = "0x1426D80")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x600C220")]
	[Address(RVA = "0x1426DA4", Offset = "0x1426DA4", VA = "0x1426DA4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C221")]
	[Address(RVA = "0x1426DAC", Offset = "0x1426DAC", VA = "0x1426DAC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C222")]
	[Address(RVA = "0x1426DB4", Offset = "0x1426DB4", VA = "0x1426DB4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C223")]
	[Address(RVA = "0x1426DBC", Offset = "0x1426DBC", VA = "0x1426DBC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
