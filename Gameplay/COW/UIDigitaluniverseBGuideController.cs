using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001ECC")]
public class UIDigitaluniverseBGuideController : UIBaseController
{
	[Token(Token = "0x2001ECD")]
	private sealed class _003CHideDragRotationGuide_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1F8")]
		[FieldOffset(Offset = "0x8")]
		internal float _003Ctime_003E__0;

		[Token(Token = "0x400C1F9")]
		[FieldOffset(Offset = "0xC")]
		internal AnimationClip _003Cclip_003E__0;

		[Token(Token = "0x400C1FA")]
		[FieldOffset(Offset = "0x10")]
		internal UIDigitaluniverseBGuideController _0024this;

		[Token(Token = "0x400C1FB")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400C1FC")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1FD")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000F58")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095D9")]
			[Address(RVA = "0x2F6657C", Offset = "0x2F6657C", VA = "0x2F6657C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F59")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095DA")]
			[Address(RVA = "0x2F66584", Offset = "0x2F66584", VA = "0x2F66584", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095D7")]
		[Address(RVA = "0x2F65F0C", Offset = "0x2F65F0C", VA = "0x2F65F0C")]
		public _003CHideDragRotationGuide_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60095D8")]
		[Address(RVA = "0x2F662E8", Offset = "0x2F662E8", VA = "0x2F662E8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095DB")]
		[Address(RVA = "0x2F6658C", Offset = "0x2F6658C", VA = "0x2F6658C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095DC")]
		[Address(RVA = "0x2F665A0", Offset = "0x2F665A0", VA = "0x2F665A0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001ECE")]
	private sealed class _003CHideSpine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1FE")]
		[FieldOffset(Offset = "0x8")]
		internal float time;

		[Token(Token = "0x400C1FF")]
		[FieldOffset(Offset = "0xC")]
		internal AnimationClip _003Cclip_003E__0;

		[Token(Token = "0x400C200")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CclipTime_003E__0;

		[Token(Token = "0x400C201")]
		[FieldOffset(Offset = "0x14")]
		internal AnimationClip _003Cclip2_003E__0;

		[Token(Token = "0x400C202")]
		[FieldOffset(Offset = "0x18")]
		internal UIDigitaluniverseBGuideController _0024this;

		[Token(Token = "0x400C203")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400C204")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400C205")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17000F5A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095DF")]
			[Address(RVA = "0x2F66A6C", Offset = "0x2F66A6C", VA = "0x2F66A6C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F5B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095E0")]
			[Address(RVA = "0x2F66A74", Offset = "0x2F66A74", VA = "0x2F66A74", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095DD")]
		[Address(RVA = "0x2F66058", Offset = "0x2F66058", VA = "0x2F66058")]
		public _003CHideSpine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x60095DE")]
		[Address(RVA = "0x2F66628", Offset = "0x2F66628", VA = "0x2F66628", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095E1")]
		[Address(RVA = "0x2F66A7C", Offset = "0x2F66A7C", VA = "0x2F66A7C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095E2")]
		[Address(RVA = "0x2F66A90", Offset = "0x2F66A90", VA = "0x2F66A90", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001ECF")]
	private sealed class _003CShowSpine_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C206")]
		[FieldOffset(Offset = "0x8")]
		internal float time;

		[Token(Token = "0x400C207")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBGuideController _0024this;

		[Token(Token = "0x400C208")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400C209")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400C20A")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000F5C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095E5")]
			[Address(RVA = "0x2F67100", Offset = "0x2F67100", VA = "0x2F67100", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F5D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095E6")]
			[Address(RVA = "0x2F67108", Offset = "0x2F67108", VA = "0x2F67108", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095E3")]
		[Address(RVA = "0x2F66060", Offset = "0x2F66060", VA = "0x2F66060")]
		public _003CShowSpine_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x60095E4")]
		[Address(RVA = "0x2F66D50", Offset = "0x2F66D50", VA = "0x2F66D50", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095E7")]
		[Address(RVA = "0x2F67110", Offset = "0x2F67110", VA = "0x2F67110", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095E8")]
		[Address(RVA = "0x2F67124", Offset = "0x2F67124", VA = "0x2F67124", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001ED0")]
	private sealed class _003CShowBtnContionue_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C20B")]
		[FieldOffset(Offset = "0x8")]
		internal float time;

		[Token(Token = "0x400C20C")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBGuideController _0024this;

		[Token(Token = "0x400C20D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400C20E")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400C20F")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000F5E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095EB")]
			[Address(RVA = "0x2F66CA4", Offset = "0x2F66CA4", VA = "0x2F66CA4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F5F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095EC")]
			[Address(RVA = "0x2F66CAC", Offset = "0x2F66CAC", VA = "0x2F66CAC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095E9")]
		[Address(RVA = "0x2F66068", Offset = "0x2F66068", VA = "0x2F66068")]
		public _003CShowBtnContionue_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x60095EA")]
		[Address(RVA = "0x2F66B18", Offset = "0x2F66B18", VA = "0x2F66B18", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095ED")]
		[Address(RVA = "0x2F66CB4", Offset = "0x2F66CB4", VA = "0x2F66CB4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095EE")]
		[Address(RVA = "0x2F66CC8", Offset = "0x2F66CC8", VA = "0x2F66CC8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C1F5")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitaluniverseBGuideView m_View;

	[Token(Token = "0x400C1F6")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C1F7")]
	[FieldOffset(Offset = "0x30")]
	private float m_RotateTime;

	[Token(Token = "0x60095CB")]
	[Address(RVA = "0x2F64F70", Offset = "0x2F64F70", VA = "0x2F64F70")]
	public UIDigitaluniverseBGuideController()
	{
	}

	[Token(Token = "0x60095CC")]
	[Address(RVA = "0x2F65000", Offset = "0x2F65000", VA = "0x2F65000")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60095CD")]
	[Address(RVA = "0x2F650A8", Offset = "0x2F650A8", VA = "0x2F650A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60095CE")]
	[Address(RVA = "0x2F65398", Offset = "0x2F65398", VA = "0x2F65398")]
	public void OnSwitchState(object[] data)
	{
	}

	[Token(Token = "0x60095CF")]
	[Address(RVA = "0x2F65E40", Offset = "0x2F65E40", VA = "0x2F65E40")]
	private IEnumerator HideDragRotationGuide()
	{
		return null;
	}

	[Token(Token = "0x60095D0")]
	[Address(RVA = "0x2F65F14", Offset = "0x2F65F14", VA = "0x2F65F14")]
	private void HideDragGuide(object[] data)
	{
	}

	[Token(Token = "0x60095D1")]
	[Address(RVA = "0x2F65C48", Offset = "0x2F65C48", VA = "0x2F65C48")]
	private IEnumerator HideSpine(float time)
	{
		return null;
	}

	[Token(Token = "0x60095D2")]
	[Address(RVA = "0x2F65B4C", Offset = "0x2F65B4C", VA = "0x2F65B4C")]
	private IEnumerator ShowSpine(float time)
	{
		return null;
	}

	[Token(Token = "0x60095D3")]
	[Address(RVA = "0x2F65D44", Offset = "0x2F65D44", VA = "0x2F65D44")]
	private IEnumerator ShowBtnContionue(float time)
	{
		return null;
	}

	[Token(Token = "0x60095D4")]
	[Address(RVA = "0x2F66070", Offset = "0x2F66070", VA = "0x2F66070")]
	private void OnBtnGoRotationClick()
	{
	}

	[Token(Token = "0x60095D5")]
	[Address(RVA = "0x2F66178", Offset = "0x2F66178", VA = "0x2F66178")]
	private void OnBtnCloseGuide5()
	{
	}

	[Token(Token = "0x60095D6")]
	[Address(RVA = "0x2F662E0", Offset = "0x2F662E0", VA = "0x2F662E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
