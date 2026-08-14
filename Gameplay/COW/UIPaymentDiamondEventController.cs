using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A26")]
public class UIPaymentDiamondEventController : UIPaymentController.PaymentTabContentController, _Attribute
{
	[Token(Token = "0x2002A27")]
	private sealed class _003CStartRunProgress_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010349")]
		[FieldOffset(Offset = "0x8")]
		internal float[] _003Cparts_003E__0;

		[Token(Token = "0x401034A")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CcurrentIndex_003E__0;

		[Token(Token = "0x401034B")]
		[FieldOffset(Offset = "0x10")]
		internal float progress;

		[Token(Token = "0x401034C")]
		[FieldOffset(Offset = "0x14")]
		internal float _003Cdelta_003E__1;

		[Token(Token = "0x401034D")]
		[FieldOffset(Offset = "0x18")]
		internal float _003Cvalue_003E__1;

		[Token(Token = "0x401034E")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003Cx_003E__1;

		[Token(Token = "0x401034F")]
		[FieldOffset(Offset = "0x20")]
		internal UIPaymentDiamondEventController _0024this;

		[Token(Token = "0x4010350")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x4010351")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x4010352")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x17001280")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60110CC")]
			[Address(RVA = "0x2885148", Offset = "0x2885148", VA = "0x2885148", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001281")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60110CD")]
			[Address(RVA = "0x2885150", Offset = "0x2885150", VA = "0x2885150", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60110CA")]
		[Address(RVA = "0x2884424", Offset = "0x2884424", VA = "0x2884424")]
		public _003CStartRunProgress_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60110CB")]
		[Address(RVA = "0x2884894", Offset = "0x2884894", VA = "0x2884894", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60110CE")]
		[Address(RVA = "0x2885158", Offset = "0x2885158", VA = "0x2885158", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60110CF")]
		[Address(RVA = "0x288516C", Offset = "0x288516C", VA = "0x288516C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002A28")]
	private sealed class _003CRefreshContentWithoutAnim_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010353")]
		[FieldOffset(Offset = "0x8")]
		internal uint goPosType;

		[Token(Token = "0x4010354")]
		[FieldOffset(Offset = "0xC")]
		internal uint goPos;

		[Token(Token = "0x4010355")]
		[FieldOffset(Offset = "0x10")]
		internal string subPos;

		[Token(Token = "0x60110D0")]
		[Address(RVA = "0x288462C", Offset = "0x288462C", VA = "0x288462C")]
		public _003CRefreshContentWithoutAnim_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60110D1")]
		[Address(RVA = "0x28846B8", Offset = "0x28846B8", VA = "0x28846B8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401032B")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentDiamondEventView m_View;

	[Token(Token = "0x401032C")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelPayment m_model;

	[Token(Token = "0x401032D")]
	[FieldOffset(Offset = "0x30")]
	private List<UIPaymentDiamondItemController> m_Items;

	[Token(Token = "0x401032E")]
	[FieldOffset(Offset = "0x34")]
	private string m_ItemIdentifier;

	[Token(Token = "0x401032F")]
	[FieldOffset(Offset = "0x38")]
	private bool m_Purchased;

	[Token(Token = "0x4010330")]
	[FieldOffset(Offset = "0x3C")]
	private int[] m_DiscountFontSize;

	[Token(Token = "0x4010331")]
	[FieldOffset(Offset = "0x40")]
	private int[] m_OffFontSize;

	[Token(Token = "0x4010332")]
	[FieldOffset(Offset = "0x44")]
	private Color[] m_OutLineColor;

	[Token(Token = "0x4010333")]
	[FieldOffset(Offset = "0x48")]
	private Color[] m_BackgroundColor;

	[Token(Token = "0x4010334")]
	[FieldOffset(Offset = "0x4C")]
	private Color[] m_BackLineColor;

	[Token(Token = "0x4010335")]
	[FieldOffset(Offset = "0x50")]
	private Color[] m_PointColor;

	[Token(Token = "0x4010336")]
	[FieldOffset(Offset = "0x54")]
	private Color[] m_BackgroundTriangleColor;

	[Token(Token = "0x4010337")]
	[FieldOffset(Offset = "0x58")]
	private Vector2[] m_BackgroundTriangleSize;

	[Token(Token = "0x4010338")]
	[FieldOffset(Offset = "0x5C")]
	private int[] m_BackgroundTrianglePositionY;

	[Token(Token = "0x4010339")]
	[FieldOffset(Offset = "0x60")]
	private string[] m_EffectID;

	[Token(Token = "0x401033A")]
	[FieldOffset(Offset = "0x64")]
	private string[] m_SoundID;

	[Token(Token = "0x401033B")]
	[FieldOffset(Offset = "0x68")]
	private int m_DefaultLabelSize;

	[Token(Token = "0x401033C")]
	[FieldOffset(Offset = "0x6C")]
	private Color m_DefaultColor;

	[Token(Token = "0x401033D")]
	[FieldOffset(Offset = "0x7C")]
	private Vector2 m_DefaultSize;

	[Token(Token = "0x401033E")]
	[FieldOffset(Offset = "0x84")]
	private int m_DefaultPositionY;

	[Token(Token = "0x401033F")]
	[FieldOffset(Offset = "0x88")]
	private Action m_ClickGoPos;

	[Token(Token = "0x4010340")]
	[FieldOffset(Offset = "0x8C")]
	private float m_Progress;

	[Token(Token = "0x4010341")]
	[FieldOffset(Offset = "0x90")]
	private uint m_DiamondCount;

	[Token(Token = "0x4010342")]
	[FieldOffset(Offset = "0x94")]
	private int m_CurrentIndex;

	[Token(Token = "0x4010343")]
	[FieldOffset(Offset = "0x98")]
	private bool m_IsNeedRefresh;

	[Token(Token = "0x4010344")]
	private const int LSMCOUNT = 4;

	[Token(Token = "0x4010345")]
	private const int ITEMWIDTH = 260;

	[Token(Token = "0x4010346")]
	[FieldOffset(Offset = "0x9C")]
	private List<UILabel> m_CountLabels;

	[Token(Token = "0x4010347")]
	[FieldOffset(Offset = "0xA0")]
	private IEnumerator m_ProgressCoroutine;

	[Token(Token = "0x4010348")]
	[FieldOffset(Offset = "0x0")]
	private static OnFinished _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60110B9")]
	[Address(RVA = "0x287FB40", Offset = "0x287FB40", VA = "0x287FB40")]
	public UIPaymentDiamondEventController()
	{
	}

	[Token(Token = "0x60110BA")]
	[Address(RVA = "0x2880860", Offset = "0x2880860", VA = "0x2880860")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60110BB")]
	[Address(RVA = "0x2880908", Offset = "0x2880908", VA = "0x2880908", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60110BC")]
	[Address(RVA = "0x2880DBC", Offset = "0x2880DBC", VA = "0x2880DBC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60110BD")]
	[Address(RVA = "0x2880E64", Offset = "0x2880E64", VA = "0x2880E64", Slot = "34")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60110BE")]
	[Address(RVA = "0x2881BD0", Offset = "0x2881BD0", VA = "0x2881BD0", Slot = "35")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60110BF")]
	[Address(RVA = "0x2881C64", Offset = "0x2881C64", VA = "0x2881C64", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x60110C0")]
	[Address(RVA = "0x2882258", Offset = "0x2882258", VA = "0x2882258")]
	private void RefreshDiamondItemList(int diamondCount)
	{
	}

	[Token(Token = "0x60110C1")]
	[Address(RVA = "0x288215C", Offset = "0x288215C", VA = "0x288215C")]
	private IEnumerator StartRunProgress(float progress)
	{
		return null;
	}

	[Token(Token = "0x60110C2")]
	[Address(RVA = "0x2881058", Offset = "0x2881058", VA = "0x2881058")]
	private void RefreshContentWithoutAnim()
	{
	}

	[Token(Token = "0x60110C3")]
	[Address(RVA = "0x28818B8", Offset = "0x28818B8", VA = "0x28818B8")]
	private void OnPurchased(string productIdentifier)
	{
	}

	[Token(Token = "0x60110C4")]
	[Address(RVA = "0x288442C", Offset = "0x288442C", VA = "0x288442C")]
	private void RefreshCountDownTime()
	{
	}

	[Token(Token = "0x60110C5")]
	[Address(RVA = "0x2884634", Offset = "0x2884634", VA = "0x2884634")]
	private void OnClickGoPos()
	{
	}

	[Token(Token = "0x60110C6")]
	[Address(RVA = "0x28846A0", Offset = "0x28846A0", VA = "0x28846A0")]
	private static void _003CRefreshCountDownTime_003Em__0()
	{
	}

	[Token(Token = "0x60110C7")]
	[Address(RVA = "0x28846A4", Offset = "0x28846A4", VA = "0x28846A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60110C8")]
	[Address(RVA = "0x28846AC", Offset = "0x28846AC", VA = "0x28846AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60110C9")]
	[Address(RVA = "0x28846B4", Offset = "0x28846B4", VA = "0x28846B4")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
