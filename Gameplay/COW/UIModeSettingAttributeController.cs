using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x20022FC")]
public class UIModeSettingAttributeController : UIBaseController, _Attribute
{
	[Token(Token = "0x20022FD")]
	private enum EEntityTypeTab
	{
		[Token(Token = "0x400DA58")]
		Global,
		[Token(Token = "0x400DA59")]
		Team,
		[Token(Token = "0x400DA5A")]
		Player,
		[Token(Token = "0x400DA5B")]
		Count
	}

	[Token(Token = "0x20022FE")]
	private sealed class _003CCheckVaild_003Ec__AnonStorey2
	{
		[Token(Token = "0x400DA5C")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x400DA5D")]
		[FieldOffset(Offset = "0xC")]
		internal UIModeSettingAttributeController _0024this;

		[Token(Token = "0x600C133")]
		[Address(RVA = "0x131755C", Offset = "0x131755C", VA = "0x131755C")]
		public _003CCheckVaild_003Ec__AnonStorey2()
		{
		}
	}

	[Token(Token = "0x20022FF")]
	private sealed class _003CCheckVaild_003Ec__AnonStorey1
	{
		[Token(Token = "0x400DA5E")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x400DA5F")]
		[FieldOffset(Offset = "0xC")]
		internal _003CCheckVaild_003Ec__AnonStorey2 _003C_003Ef__ref_00242;

		[Token(Token = "0x600C134")]
		[Address(RVA = "0x1317564", Offset = "0x1317564", VA = "0x1317564")]
		public _003CCheckVaild_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600C135")]
		[Address(RVA = "0x1317D1C", Offset = "0x1317D1C", VA = "0x1317D1C")]
		internal bool _003C_003Em__0(DJMFJEMEKHM data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002300")]
	private sealed class _003CWaitOneFrameUpdateAnchors_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DA60")]
		[FieldOffset(Offset = "0x8")]
		internal UIWidget _003Cwidget_003E__0;

		[Token(Token = "0x400DA61")]
		[FieldOffset(Offset = "0xC")]
		internal UIModeSettingAttributeController _0024this;

		[Token(Token = "0x400DA62")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400DA63")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400DA64")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170010AA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C138")]
			[Address(RVA = "0x1317FE8", Offset = "0x1317FE8", VA = "0x1317FE8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010AB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C139")]
			[Address(RVA = "0x1317FF0", Offset = "0x1317FF0", VA = "0x1317FF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C136")]
		[Address(RVA = "0x1317A6C", Offset = "0x1317A6C", VA = "0x1317A6C")]
		public _003CWaitOneFrameUpdateAnchors_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C137")]
		[Address(RVA = "0x1317E78", Offset = "0x1317E78", VA = "0x1317E78", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C13A")]
		[Address(RVA = "0x1317FF8", Offset = "0x1317FF8", VA = "0x1317FF8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C13B")]
		[Address(RVA = "0x131800C", Offset = "0x131800C", VA = "0x131800C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DA52")]
	[FieldOffset(Offset = "0x28")]
	private UIModeSettingAttributeView m_View;

	[Token(Token = "0x400DA53")]
	[FieldOffset(Offset = "0x2C")]
	private CEIJKFCIALJ m_CurrentEntityAttributeData;

	[Token(Token = "0x400DA54")]
	[FieldOffset(Offset = "0x30")]
	private CEIJKFCIALJ[] m_EntityAttributeData;

	[Token(Token = "0x400DA55")]
	[FieldOffset(Offset = "0x34")]
	private Transform[] m_TabTransRoot;

	[Token(Token = "0x400DA56")]
	[FieldOffset(Offset = "0x38")]
	private EEntityTypeTab m_CurrentTab;

	[Token(Token = "0x170010A9")]
	private int m_MaxAttributeCount
	{
		[Token(Token = "0x600C120")]
		[Address(RVA = "0x1315924", Offset = "0x1315924", VA = "0x1315924")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600C11F")]
	[Address(RVA = "0x13158A0", Offset = "0x13158A0", VA = "0x13158A0")]
	public UIModeSettingAttributeController()
	{
	}

	[Token(Token = "0x600C121")]
	[Address(RVA = "0x1315A40", Offset = "0x1315A40", VA = "0x1315A40")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C122")]
	[Address(RVA = "0x1315AE8", Offset = "0x1315AE8", VA = "0x1315AE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C123")]
	[Address(RVA = "0x131652C", Offset = "0x131652C", VA = "0x131652C")]
	private void OnClickGlobalTab()
	{
	}

	[Token(Token = "0x600C124")]
	[Address(RVA = "0x131692C", Offset = "0x131692C", VA = "0x131692C")]
	private void OnClickTeamTab()
	{
	}

	[Token(Token = "0x600C125")]
	[Address(RVA = "0x1316990", Offset = "0x1316990", VA = "0x1316990")]
	private void OnPlayerTab()
	{
	}

	[Token(Token = "0x600C126")]
	[Address(RVA = "0x1316590", Offset = "0x1316590", VA = "0x1316590")]
	private void RefreshTabView(EEntityTypeTab tab)
	{
	}

	[Token(Token = "0x600C127")]
	[Address(RVA = "0x13169F4", Offset = "0x13169F4", VA = "0x13169F4")]
	private void OnAddBtnClick()
	{
	}

	[Token(Token = "0x600C128")]
	[Address(RVA = "0x1316D74", Offset = "0x1316D74", VA = "0x1316D74")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600C129")]
	[Address(RVA = "0x131717C", Offset = "0x131717C", VA = "0x131717C")]
	private bool CheckVaild(out string reason)
	{
		return default(bool);
	}

	[Token(Token = "0x600C12A")]
	[Address(RVA = "0x13174D0", Offset = "0x13174D0", VA = "0x13174D0")]
	private FONLAPPBCOO GetLogicEntityTypeByTab(EEntityTypeTab tab)
	{
		return default(FONLAPPBCOO);
	}

	[Token(Token = "0x600C12B")]
	[Address(RVA = "0x1316090", Offset = "0x1316090", VA = "0x1316090")]
	private void SetEntityAttributeDate()
	{
	}

	[Token(Token = "0x600C12C")]
	[Address(RVA = "0x131628C", Offset = "0x131628C", VA = "0x131628C")]
	private void RefreshAttributeListView()
	{
	}

	[Token(Token = "0x600C12D")]
	[Address(RVA = "0x131756C", Offset = "0x131756C", VA = "0x131756C", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C12E")]
	[Address(RVA = "0x13175E8", Offset = "0x13175E8", VA = "0x13175E8", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C12F")]
	[Address(RVA = "0x1317930", Offset = "0x1317930", VA = "0x1317930")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600C130")]
	[Address(RVA = "0x13179A0", Offset = "0x13179A0", VA = "0x13179A0")]
	private IEnumerator WaitOneFrameUpdateAnchors()
	{
		return null;
	}

	[Token(Token = "0x600C131")]
	[Address(RVA = "0x1317A74", Offset = "0x1317A74", VA = "0x1317A74")]
	private void DeleteAttribute(object[] param)
	{
	}

	[Token(Token = "0x600C132")]
	[Address(RVA = "0x1317D14", Offset = "0x1317D14", VA = "0x1317D14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
