using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x20028A5")]
internal class UIHudVehicleDriverFireController : UIHudVehicleItemButtonController
{
	[Token(Token = "0x20028A6")]
	private sealed class MHNKJJJNBIM : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FA2E")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudVehicleDriverFireController GADHAMJEKIM;

		[Token(Token = "0x400FA2F")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400FA30")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400FA31")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17001203")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600FF6F")]
			[Address(RVA = "0x18F7DC8", Offset = "0x18F7DC8", VA = "0x18F7DC8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001204")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600FF70")]
			[Address(RVA = "0x18F7DD0", Offset = "0x18F7DD0", VA = "0x18F7DD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600FF6D")]
		[Address(RVA = "0x18F6F9C", Offset = "0x18F6F9C", VA = "0x18F6F9C")]
		public MHNKJJJNBIM()
		{
		}

		[Token(Token = "0x600FF6E")]
		[Address(RVA = "0x18F7D00", Offset = "0x18F7D00", VA = "0x18F7D00", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600FF71")]
		[Address(RVA = "0x18F7DD8", Offset = "0x18F7DD8", VA = "0x18F7DD8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600FF72")]
		[Address(RVA = "0x18F7DEC", Offset = "0x18F7DEC", VA = "0x18F7DEC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FA1A")]
	[FieldOffset(Offset = "0x44")]
	private UIHudVehicleDriverFireView NOJLDPLOCIH;

	[Token(Token = "0x400FA1B")]
	[FieldOffset(Offset = "0x48")]
	private Player FJPEHEGICBO;

	[Token(Token = "0x400FA1C")]
	[FieldOffset(Offset = "0x4C")]
	private Vehicle NDNNIIKIDBO;

	[Token(Token = "0x400FA1D")]
	[FieldOffset(Offset = "0x50")]
	private FGJEBMEEIGM BBFOPEGKDEO;

	[Token(Token = "0x400FA1E")]
	[FieldOffset(Offset = "0x54")]
	private bool CLMKOGPMNFJ;

	[Token(Token = "0x400FA1F")]
	private const int LACLHHAEPDD = 1;

	[Token(Token = "0x400FA20")]
	private const float FABGMKNJHJA = 0.15f;

	[Token(Token = "0x400FA21")]
	[FieldOffset(Offset = "0x58")]
	private float LKBAMLNEEJJ;

	[Token(Token = "0x400FA22")]
	[FieldOffset(Offset = "0x5C")]
	private int MPBDGPCCLMC;

	[Token(Token = "0x400FA23")]
	[FieldOffset(Offset = "0x60")]
	private float FPIILGACHIM;

	[Token(Token = "0x400FA24")]
	[FieldOffset(Offset = "0x64")]
	private bool PCIMOCLBBHL;

	[Token(Token = "0x400FA25")]
	[FieldOffset(Offset = "0x68")]
	private UserControlHandler JOGCIACBNKP;

	[Token(Token = "0x400FA26")]
	[FieldOffset(Offset = "0x6C")]
	private UserControlAxisData BBKEODKGKGD;

	[Token(Token = "0x400FA27")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 FIMDABNBDKJ;

	[Token(Token = "0x400FA28")]
	[FieldOffset(Offset = "0x7C")]
	private bool JMAKNONBLOP;

	[Token(Token = "0x400FA29")]
	[FieldOffset(Offset = "0x7D")]
	private bool LFCOCNEMING;

	[Token(Token = "0x400FA2A")]
	[FieldOffset(Offset = "0x80")]
	private Color EOACJANGHGC;

	[Token(Token = "0x400FA2B")]
	[FieldOffset(Offset = "0x90")]
	private Color MLKKCFHCNEF;

	[Token(Token = "0x400FA2C")]
	[FieldOffset(Offset = "0xA0")]
	private Color OKOLOJHILDE;

	[Token(Token = "0x400FA2D")]
	[FieldOffset(Offset = "0xB0")]
	private Color KJNAOGBEHKC;

	[Token(Token = "0x17001202")]
	private float OGNEMBLIAON
	{
		[Token(Token = "0x600FF63")]
		[Address(RVA = "0x18F7354", Offset = "0x18F7354", VA = "0x18F7354")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600FF56")]
	[Address(RVA = "0x18F6324", Offset = "0x18F6324", VA = "0x18F6324")]
	public UIHudVehicleDriverFireController()
	{
	}

	[Token(Token = "0x600FF57")]
	[Address(RVA = "0x18F641C", Offset = "0x18F641C", VA = "0x18F641C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FF58")]
	[Address(RVA = "0x18F6480", Offset = "0x18F6480", VA = "0x18F6480", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FF59")]
	[Address(RVA = "0x18F6740", Offset = "0x18F6740", VA = "0x18F6740", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FF5A")]
	[Address(RVA = "0x18F679C", Offset = "0x18F679C", VA = "0x18F679C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FF5B")]
	[Address(RVA = "0x18F6AA0", Offset = "0x18F6AA0", VA = "0x18F6AA0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FF5C")]
	[Address(RVA = "0x18F6E6C", Offset = "0x18F6E6C", VA = "0x18F6E6C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600FF5D")]
	[Address(RVA = "0x18F6F14", Offset = "0x18F6F14", VA = "0x18F6F14")]
	private void EHABGMBEIIL(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600FF5E")]
	[Address(RVA = "0x18F6A34", Offset = "0x18F6A34", VA = "0x18F6A34")]
	private void JPKDHPJJFDI()
	{
	}

	[Token(Token = "0x600FF5F")]
	[Address(RVA = "0x18F6F18", Offset = "0x18F6F18", VA = "0x18F6F18")]
	private IEnumerator BGFMNHJDNAK()
	{
		return null;
	}

	[Token(Token = "0x600FF60")]
	[Address(RVA = "0x18F6FA4", Offset = "0x18F6FA4", VA = "0x18F6FA4")]
	private void DALLEBHIGOL()
	{
	}

	[Token(Token = "0x600FF61")]
	[Address(RVA = "0x18F7334", Offset = "0x18F7334", VA = "0x18F7334", Slot = "31")]
	protected override void OnBtnDown()
	{
	}

	[Token(Token = "0x600FF62")]
	[Address(RVA = "0x18F73F0", Offset = "0x18F73F0", VA = "0x18F73F0", Slot = "32")]
	protected override void OnBtnUp()
	{
	}

	[Token(Token = "0x600FF64")]
	[Address(RVA = "0x18F6880", Offset = "0x18F6880", VA = "0x18F6880")]
	private void IHGOBGKIHPG()
	{
	}

	[Token(Token = "0x600FF65")]
	[Address(RVA = "0x18F7410", Offset = "0x18F7410", VA = "0x18F7410", Slot = "39")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600FF66")]
	[Address(RVA = "0x18F763C", Offset = "0x18F763C", VA = "0x18F763C")]
	private void OFPPPGJCFEB(bool HGMBMICDALC)
	{
	}

	[Token(Token = "0x600FF67")]
	[Address(RVA = "0x18F7A98", Offset = "0x18F7A98", VA = "0x18F7A98")]
	private void NBDPEBMGKMM()
	{
	}

	[Token(Token = "0x600FF68")]
	[Address(RVA = "0x18F6BFC", Offset = "0x18F6BFC", VA = "0x18F6BFC")]
	private void MKNGCEDAPGD()
	{
	}

	[Token(Token = "0x600FF69")]
	[Address(RVA = "0x18F77C0", Offset = "0x18F77C0", VA = "0x18F77C0")]
	private bool PNGLKJIIGJC()
	{
		return default(bool);
	}

	[Token(Token = "0x600FF6A")]
	[Address(RVA = "0x18F7CB8", Offset = "0x18F7CB8", VA = "0x18F7CB8")]
	private void DCBFENILONN(object[] GIHMAEJEIPE)
	{
	}

	[Token(Token = "0x600FF6B")]
	[Address(RVA = "0x18F7A80", Offset = "0x18F7A80", VA = "0x18F7A80")]
	private void DLDHPOEMOJB()
	{
	}

	[Token(Token = "0x600FF6C")]
	[Address(RVA = "0x18F6E68", Offset = "0x18F6E68", VA = "0x18F6E68")]
	private void ACCBMHMFIJP()
	{
	}
}
