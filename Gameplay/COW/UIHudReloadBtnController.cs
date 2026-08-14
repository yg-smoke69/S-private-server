using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002827")]
internal class UIHudReloadBtnController : UIHudButtonBaseController
{
	[Token(Token = "0x2002828")]
	private sealed class _003CStartCooldown_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F7C5")]
		[FieldOffset(Offset = "0x8")]
		internal float f;

		[Token(Token = "0x400F7C6")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Ct_003E__0;

		[Token(Token = "0x400F7C7")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudReloadBtnController _0024this;

		[Token(Token = "0x400F7C8")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400F7C9")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400F7CA")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x170011F0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600FA53")]
			[Address(RVA = "0x13E0440", Offset = "0x13E0440", VA = "0x13E0440", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011F1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600FA54")]
			[Address(RVA = "0x13E0448", Offset = "0x13E0448", VA = "0x13E0448", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600FA51")]
		[Address(RVA = "0x13E0284", Offset = "0x13E0284", VA = "0x13E0284")]
		public _003CStartCooldown_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600FA52")]
		[Address(RVA = "0x13E02BC", Offset = "0x13E02BC", VA = "0x13E02BC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600FA55")]
		[Address(RVA = "0x13E0450", Offset = "0x13E0450", VA = "0x13E0450", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600FA56")]
		[Address(RVA = "0x13E0464", Offset = "0x13E0464", VA = "0x13E0464", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F7C2")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudReloadBtnView m_View;

	[Token(Token = "0x400F7C3")]
	[FieldOffset(Offset = "0x30")]
	private EReloadSetting m_ShowTiming;

	[Token(Token = "0x400F7C4")]
	[FieldOffset(Offset = "0x34")]
	private IEnumerator m_CurrentCoroutine;

	[Token(Token = "0x600FA39")]
	[Address(RVA = "0x13DEE9C", Offset = "0x13DEE9C", VA = "0x13DEE9C")]
	public UIHudReloadBtnController()
	{
	}

	[Token(Token = "0x600FA3A")]
	[Address(RVA = "0x13DEEA4", Offset = "0x13DEEA4", VA = "0x13DEEA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FA3B")]
	[Address(RVA = "0x13DEF48", Offset = "0x13DEF48", VA = "0x13DEF48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FA3C")]
	[Address(RVA = "0x13DF25C", Offset = "0x13DF25C", VA = "0x13DF25C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FA3D")]
	[Address(RVA = "0x13DF530", Offset = "0x13DF530", VA = "0x13DF530", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FA3E")]
	[Address(RVA = "0x13DF83C", Offset = "0x13DF83C", VA = "0x13DF83C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FA3F")]
	[Address(RVA = "0x13DF8E0", Offset = "0x13DF8E0", VA = "0x13DF8E0", Slot = "31")]
	protected override void OnBtnDown()
	{
	}

	[Token(Token = "0x600FA40")]
	[Address(RVA = "0x13DF944", Offset = "0x13DF944", VA = "0x13DF944", Slot = "32")]
	protected override void OnBtnUp()
	{
	}

	[Token(Token = "0x600FA41")]
	[Address(RVA = "0x13DF9A8", Offset = "0x13DF9A8", VA = "0x13DF9A8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600FA42")]
	[Address(RVA = "0x13DFD68", Offset = "0x13DFD68", VA = "0x13DFD68")]
	private void OnHudSettingChange(object[] param)
	{
	}

	[Token(Token = "0x600FA43")]
	[Address(RVA = "0x13DFDD8", Offset = "0x13DFDD8", VA = "0x13DFDD8")]
	private void OnWeaponReload(object[] data)
	{
	}

	[Token(Token = "0x600FA44")]
	[Address(RVA = "0x13DFEF0", Offset = "0x13DFEF0", VA = "0x13DFEF0")]
	private void OnWeaponReloadEnd(object[] data)
	{
	}

	[Token(Token = "0x600FA45")]
	[Address(RVA = "0x13DFF7C", Offset = "0x13DFF7C", VA = "0x13DFF7C")]
	private void OnWeaponChanged(object[] data)
	{
	}

	[Token(Token = "0x600FA46")]
	[Address(RVA = "0x13DFFF4", Offset = "0x13DFFF4", VA = "0x13DFFF4")]
	private void OnItemChange(object[] data)
	{
	}

	[Token(Token = "0x600FA47")]
	[Address(RVA = "0x13DF5A4", Offset = "0x13DF5A4", VA = "0x13DF5A4")]
	private void UpdateShowTiming()
	{
	}

	[Token(Token = "0x600FA48")]
	[Address(RVA = "0x13DF670", Offset = "0x13DF670", VA = "0x13DF670")]
	private void UpdateShowHide()
	{
	}

	[Token(Token = "0x600FA49")]
	[Address(RVA = "0x13DFA3C", Offset = "0x13DFA3C", VA = "0x13DFA3C")]
	private void UpdateCd(bool reloading, float cd)
	{
	}

	[Token(Token = "0x600FA4A")]
	[Address(RVA = "0x13E0188", Offset = "0x13E0188", VA = "0x13E0188")]
	private IEnumerator StartCooldown(float f)
	{
		return null;
	}

	[Token(Token = "0x600FA4B")]
	[Address(RVA = "0x13E028C", Offset = "0x13E028C", VA = "0x13E028C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FA4C")]
	[Address(RVA = "0x13E0294", Offset = "0x13E0294", VA = "0x13E0294")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FA4D")]
	[Address(RVA = "0x13E029C", Offset = "0x13E029C", VA = "0x13E029C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FA4E")]
	[Address(RVA = "0x13E02A4", Offset = "0x13E02A4", VA = "0x13E02A4")]
	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	[Token(Token = "0x600FA4F")]
	[Address(RVA = "0x13E02AC", Offset = "0x13E02AC", VA = "0x13E02AC")]
	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}

	[Token(Token = "0x600FA50")]
	[Address(RVA = "0x13E02B4", Offset = "0x13E02B4", VA = "0x13E02B4")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
