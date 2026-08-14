using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B08")]
public class UISceneEditSubscriptionInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002B09")]
	private sealed class _003CResizeUI_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010816")]
		[FieldOffset(Offset = "0x8")]
		internal UISceneEditSubscriptionInfoController _0024this;

		[Token(Token = "0x4010817")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010818")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010819")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012DF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6011AD4")]
			[Address(RVA = "0x2DB23A0", Offset = "0x2DB23A0", VA = "0x2DB23A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012E0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6011AD5")]
			[Address(RVA = "0x2DB23A8", Offset = "0x2DB23A8", VA = "0x2DB23A8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6011AD2")]
		[Address(RVA = "0x2DB1010", Offset = "0x2DB1010", VA = "0x2DB1010")]
		public _003CResizeUI_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6011AD3")]
		[Address(RVA = "0x2DB2298", Offset = "0x2DB2298", VA = "0x2DB2298", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6011AD6")]
		[Address(RVA = "0x2DB23B0", Offset = "0x2DB23B0", VA = "0x2DB23B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6011AD7")]
		[Address(RVA = "0x2DB23C4", Offset = "0x2DB23C4", VA = "0x2DB23C4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401080F")]
	[FieldOffset(Offset = "0x28")]
	private UISceneEditSubscriptionInfoView m_View;

	[Token(Token = "0x4010810")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x4010811")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsUIResized;

	[Token(Token = "0x4010812")]
	[FieldOffset(Offset = "0x34")]
	private List<UISceneEditSubscriptionSlotItemController> m_CachedSubscriptionList;

	[Token(Token = "0x4010813")]
	[FieldOffset(Offset = "0x38")]
	private List<UISceneEditSubscriptionSlotItemController> m_CachedUpdatedList;

	[Token(Token = "0x4010814")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<SceneEditSlotInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010815")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<SceneEditSlotInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6011AC4")]
	[Address(RVA = "0x2DB0000", Offset = "0x2DB0000", VA = "0x2DB0000")]
	public UISceneEditSubscriptionInfoController()
	{
	}

	[Token(Token = "0x6011AC5")]
	[Address(RVA = "0x2DB00D0", Offset = "0x2DB00D0", VA = "0x2DB00D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011AC6")]
	[Address(RVA = "0x2DB0178", Offset = "0x2DB0178", VA = "0x2DB0178", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011AC7")]
	[Address(RVA = "0x2DB0424", Offset = "0x2DB0424", VA = "0x2DB0424", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011AC8")]
	[Address(RVA = "0x2DB04C8", Offset = "0x2DB04C8", VA = "0x2DB04C8")]
	private IEnumerator ResizeUI()
	{
		return null;
	}

	[Token(Token = "0x6011AC9")]
	[Address(RVA = "0x2DB0594", Offset = "0x2DB0594", VA = "0x2DB0594")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6011ACA")]
	[Address(RVA = "0x2DB1BC0", Offset = "0x2DB1BC0", VA = "0x2DB1BC0")]
	private void OnBtnSearchClick()
	{
	}

	[Token(Token = "0x6011ACB")]
	[Address(RVA = "0x2DB1FF0", Offset = "0x2DB1FF0", VA = "0x2DB1FF0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011ACC")]
	[Address(RVA = "0x2DB2084", Offset = "0x2DB2084", VA = "0x2DB2084", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011ACD")]
	[Address(RVA = "0x2DB21D0", Offset = "0x2DB21D0", VA = "0x2DB21D0")]
	private static bool _003CRefreshUI_003Em__0(SceneEditSlotInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x6011ACE")]
	[Address(RVA = "0x2DB21FC", Offset = "0x2DB21FC", VA = "0x2DB21FC")]
	private bool _003CRefreshUI_003Em__1(SceneEditSlotInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x6011ACF")]
	[Address(RVA = "0x2DB2230", Offset = "0x2DB2230", VA = "0x2DB2230")]
	private static int _003CRefreshUI_003Em__2(SceneEditSlotInfo a, SceneEditSlotInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6011AD0")]
	[Address(RVA = "0x2DB2288", Offset = "0x2DB2288", VA = "0x2DB2288")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011AD1")]
	[Address(RVA = "0x2DB2290", Offset = "0x2DB2290", VA = "0x2DB2290")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
