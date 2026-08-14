using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023F6")]
public class UICommonTweenTipsController : UIBaseController
{
	[Token(Token = "0x20023F7")]
	private sealed class _003COnFinished_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E047")]
		[FieldOffset(Offset = "0x8")]
		internal UICommonTweenTipsController _0024this;

		[Token(Token = "0x400E048")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400E049")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400E04A")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010EB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600CB12")]
			[Address(RVA = "0x1EBDC40", Offset = "0x1EBDC40", VA = "0x1EBDC40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010EC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600CB13")]
			[Address(RVA = "0x1EBDC48", Offset = "0x1EBDC48", VA = "0x1EBDC48", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600CB10")]
		[Address(RVA = "0x1EBD5F8", Offset = "0x1EBD5F8", VA = "0x1EBD5F8")]
		public _003COnFinished_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600CB11")]
		[Address(RVA = "0x1EBD908", Offset = "0x1EBD908", VA = "0x1EBD908", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600CB14")]
		[Address(RVA = "0x1EBDC50", Offset = "0x1EBDC50", VA = "0x1EBDC50", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600CB15")]
		[Address(RVA = "0x1EBDC64", Offset = "0x1EBDC64", VA = "0x1EBDC64", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20023F8")]
	private sealed class _003CHoldOnAnim_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E04B")]
		[FieldOffset(Offset = "0x8")]
		internal UICommonTweenTipsController _0024this;

		[Token(Token = "0x400E04C")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400E04D")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400E04E")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010ED")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600CB18")]
			[Address(RVA = "0x1EBD85C", Offset = "0x1EBD85C", VA = "0x1EBD85C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010EE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600CB19")]
			[Address(RVA = "0x1EBD864", Offset = "0x1EBD864", VA = "0x1EBD864", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600CB16")]
		[Address(RVA = "0x1EBD600", Offset = "0x1EBD600", VA = "0x1EBD600")]
		public _003CHoldOnAnim_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600CB17")]
		[Address(RVA = "0x1EBD6B4", Offset = "0x1EBD6B4", VA = "0x1EBD6B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600CB1A")]
		[Address(RVA = "0x1EBD86C", Offset = "0x1EBD86C", VA = "0x1EBD86C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600CB1B")]
		[Address(RVA = "0x1EBD880", Offset = "0x1EBD880", VA = "0x1EBD880", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E03F")]
	[FieldOffset(Offset = "0x28")]
	private UICommonTweenTipsView m_View;

	[Token(Token = "0x400E040")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_BasePos;

	[Token(Token = "0x400E041")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_CurrentPos;

	[Token(Token = "0x400E042")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 m_Offset;

	[Token(Token = "0x400E043")]
	[FieldOffset(Offset = "0x50")]
	private float m_ClipLength;

	[Token(Token = "0x400E044")]
	[FieldOffset(Offset = "0x54")]
	private Animation m_Anim;

	[Token(Token = "0x400E045")]
	[FieldOffset(Offset = "0x58")]
	private TweenPosition m_ParentTP;

	[Token(Token = "0x400E046")]
	[FieldOffset(Offset = "0x5C")]
	private float m_HoldOnTime;

	[Token(Token = "0x600CB02")]
	[Address(RVA = "0x1EBC398", Offset = "0x1EBC398", VA = "0x1EBC398")]
	public UICommonTweenTipsController()
	{
	}

	[Token(Token = "0x600CB03")]
	[Address(RVA = "0x1EBC41C", Offset = "0x1EBC41C", VA = "0x1EBC41C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CB04")]
	[Address(RVA = "0x1EBC4C0", Offset = "0x1EBC4C0", VA = "0x1EBC4C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CB05")]
	[Address(RVA = "0x1EBC6F8", Offset = "0x1EBC6F8", VA = "0x1EBC6F8")]
	public void MoveUp()
	{
	}

	[Token(Token = "0x600CB06")]
	[Address(RVA = "0x1EBC89C", Offset = "0x1EBC89C", VA = "0x1EBC89C")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x600CB07")]
	[Address(RVA = "0x1EBC934", Offset = "0x1EBC934", VA = "0x1EBC934")]
	public void ShowTips(string tips, float holdOnTime = 0f)
	{
	}

	[Token(Token = "0x600CB08")]
	[Address(RVA = "0x1EBCB88", Offset = "0x1EBCB88", VA = "0x1EBCB88")]
	public void ShowTips(BaseItemInfo itemInfo)
	{
	}

	[Token(Token = "0x600CB09")]
	[Address(RVA = "0x1EBCDD4", Offset = "0x1EBCDD4", VA = "0x1EBCDD4")]
	public void ShowTips(ResourceID resId, uint cnt)
	{
	}

	[Token(Token = "0x600CB0A")]
	[Address(RVA = "0x1EBD314", Offset = "0x1EBD314", VA = "0x1EBD314")]
	public void ShowTips(string text, List<ResourceID> iconResList)
	{
	}

	[Token(Token = "0x600CB0B")]
	[Address(RVA = "0x1EBD52C", Offset = "0x1EBD52C", VA = "0x1EBD52C")]
	public IEnumerator OnFinished()
	{
		return null;
	}

	[Token(Token = "0x600CB0C")]
	[Address(RVA = "0x1EBCABC", Offset = "0x1EBCABC", VA = "0x1EBCABC")]
	public IEnumerator HoldOnAnim()
	{
		return null;
	}

	[Token(Token = "0x600CB0D")]
	[Address(RVA = "0x1EBD608", Offset = "0x1EBD608", VA = "0x1EBD608", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600CB0E")]
	[Address(RVA = "0x1EBD6A4", Offset = "0x1EBD6A4", VA = "0x1EBD6A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CB0F")]
	[Address(RVA = "0x1EBD6AC", Offset = "0x1EBD6AC", VA = "0x1EBD6AC")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
