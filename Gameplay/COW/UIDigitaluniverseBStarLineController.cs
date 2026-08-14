using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EF3")]
public class UIDigitaluniverseBStarLineController : UIBaseController
{
	[Token(Token = "0x2001EF4")]
	private sealed class _003CPlayDisappearAnimation_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C2E1")]
		[FieldOffset(Offset = "0x8")]
		internal AnimationClip _003Cclip_003E__0;

		[Token(Token = "0x400C2E2")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBStarLineController _0024this;

		[Token(Token = "0x400C2E3")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400C2E4")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400C2E5")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000F6A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009744")]
			[Address(RVA = "0x2F0D978", Offset = "0x2F0D978", VA = "0x2F0D978", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F6B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009745")]
			[Address(RVA = "0x2F0D980", Offset = "0x2F0D980", VA = "0x2F0D980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009742")]
		[Address(RVA = "0x2F0D580", Offset = "0x2F0D580", VA = "0x2F0D580")]
		public _003CPlayDisappearAnimation_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009743")]
		[Address(RVA = "0x2F0D664", Offset = "0x2F0D664", VA = "0x2F0D664", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009746")]
		[Address(RVA = "0x2F0D988", Offset = "0x2F0D988", VA = "0x2F0D988", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009747")]
		[Address(RVA = "0x2F0D99C", Offset = "0x2F0D99C", VA = "0x2F0D99C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EF5")]
	private sealed class _003CPlayGenerationAnimation_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C2E6")]
		[FieldOffset(Offset = "0x8")]
		internal AnimationClip _003Cclip_003E__0;

		[Token(Token = "0x400C2E7")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBStarLineController _0024this;

		[Token(Token = "0x400C2E8")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400C2E9")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400C2EA")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000F6C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600974A")]
			[Address(RVA = "0x2F0DD08", Offset = "0x2F0DD08", VA = "0x2F0DD08", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F6D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600974B")]
			[Address(RVA = "0x2F0DD10", Offset = "0x2F0DD10", VA = "0x2F0DD10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009748")]
		[Address(RVA = "0x2F0D654", Offset = "0x2F0D654", VA = "0x2F0D654")]
		public _003CPlayGenerationAnimation_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6009749")]
		[Address(RVA = "0x2F0DA24", Offset = "0x2F0DA24", VA = "0x2F0DA24", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600974C")]
		[Address(RVA = "0x2F0DD18", Offset = "0x2F0DD18", VA = "0x2F0DD18", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600974D")]
		[Address(RVA = "0x2F0DD2C", Offset = "0x2F0DD2C", VA = "0x2F0DD2C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C2DF")]
	private const string ANIMATIONCLIPNAME = "VFX_UIDigitaluniverseBStarLine";

	[Token(Token = "0x400C2E0")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitaluniverseBStarLineView m_View;

	[Token(Token = "0x600973B")]
	[Address(RVA = "0x2F0D234", Offset = "0x2F0D234", VA = "0x2F0D234")]
	public UIDigitaluniverseBStarLineController()
	{
	}

	[Token(Token = "0x600973C")]
	[Address(RVA = "0x2F0D2B8", Offset = "0x2F0D2B8", VA = "0x2F0D2B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600973D")]
	[Address(RVA = "0x2F0D360", Offset = "0x2F0D360", VA = "0x2F0D360", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600973E")]
	[Address(RVA = "0x2F0D41C", Offset = "0x2F0D41C", VA = "0x2F0D41C")]
	public void SetViewData(List<Transform> list)
	{
	}

	[Token(Token = "0x600973F")]
	[Address(RVA = "0x2F0D4B4", Offset = "0x2F0D4B4", VA = "0x2F0D4B4")]
	public IEnumerator PlayDisappearAnimation()
	{
		return null;
	}

	[Token(Token = "0x6009740")]
	[Address(RVA = "0x2F0D588", Offset = "0x2F0D588", VA = "0x2F0D588")]
	public IEnumerator PlayGenerationAnimation()
	{
		return null;
	}

	[Token(Token = "0x6009741")]
	[Address(RVA = "0x2F0D65C", Offset = "0x2F0D65C", VA = "0x2F0D65C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
