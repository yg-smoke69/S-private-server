using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000D1C")]
internal class VehicleEffect : MonoBehaviour
{
	[Token(Token = "0x2000D1D")]
	private enum ICJLIMLLBGE
	{
		[Token(Token = "0x4006A4F")]
		None,
		[Token(Token = "0x4006A50")]
		Low,
		[Token(Token = "0x4006A51")]
		Middle,
		[Token(Token = "0x4006A52")]
		High,
		[Token(Token = "0x4006A53")]
		Max
	}

	[Token(Token = "0x2000D1E")]
	public enum OKIJKJCNHAC
	{
		[Token(Token = "0x4006A55")]
		None,
		[Token(Token = "0x4006A56")]
		Left,
		[Token(Token = "0x4006A57")]
		Right
	}

	[Token(Token = "0x2000D1F")]
	public enum JILIKHOBEEB
	{
		[Token(Token = "0x4006A59")]
		None,
		[Token(Token = "0x4006A5A")]
		Front,
		[Token(Token = "0x4006A5B")]
		Back,
		[Token(Token = "0x4006A5C")]
		Tailing
	}

	[Token(Token = "0x2000D20")]
	private sealed class CGOKNHHEFHI : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4006A5D")]
		[FieldOffset(Offset = "0x8")]
		internal VehicleEffect GADHAMJEKIM;

		[Token(Token = "0x4006A5E")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4006A5F")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4006A60")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x1700087B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006472")]
			[Address(RVA = "0x26EF948", Offset = "0x26EF948", VA = "0x26EF948", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700087C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006473")]
			[Address(RVA = "0x26EF950", Offset = "0x26EF950", VA = "0x26EF950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006470")]
		[Address(RVA = "0x26ED174", Offset = "0x26ED174", VA = "0x26ED174")]
		public CGOKNHHEFHI()
		{
		}

		[Token(Token = "0x6006471")]
		[Address(RVA = "0x26EF848", Offset = "0x26EF848", VA = "0x26EF848", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006474")]
		[Address(RVA = "0x26EF958", Offset = "0x26EF958", VA = "0x26EF958", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006475")]
		[Address(RVA = "0x26EF96C", Offset = "0x26EF96C", VA = "0x26EF96C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000D21")]
	private sealed class CCPPCHNFNGJ
	{
		[Token(Token = "0x4006A61")]
		[FieldOffset(Offset = "0x8")]
		internal TrailRenderer ELPJEIJFLNJ;

		[Token(Token = "0x6006476")]
		[Address(RVA = "0x26EE468", Offset = "0x26EE468", VA = "0x26EE468")]
		public CCPPCHNFNGJ()
		{
		}

		[Token(Token = "0x6006477")]
		[Address(RVA = "0x26EF6B8", Offset = "0x26EF6B8", VA = "0x26EF6B8")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x4006A35")]
	[FieldOffset(Offset = "0xC")]
	public Vehicle attachVehicle;

	[Token(Token = "0x4006A36")]
	[FieldOffset(Offset = "0x10")]
	public OKIJKJCNHAC shoalEffectType;

	[Token(Token = "0x4006A37")]
	[FieldOffset(Offset = "0x14")]
	public GameObject shoalEffect;

	[Token(Token = "0x4006A38")]
	[FieldOffset(Offset = "0x18")]
	public JILIKHOBEEB m_WaterEffectType;

	[Token(Token = "0x4006A39")]
	[FieldOffset(Offset = "0x1C")]
	public Transform m_WaterEffectPos;

	[Token(Token = "0x4006A3A")]
	[FieldOffset(Offset = "0x20")]
	private VehicleInWaterEffectParams EMJCACJINNP;

	[Token(Token = "0x4006A3B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject waterEffect;

	[Token(Token = "0x4006A3C")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem[] dustEffect;

	[Token(Token = "0x4006A3D")]
	[FieldOffset(Offset = "0x2C")]
	public Transform[] dustSpawnPos;

	[Token(Token = "0x4006A3E")]
	[FieldOffset(Offset = "0x30")]
	public float dustSimSpeed;

	[Token(Token = "0x4006A3F")]
	[FieldOffset(Offset = "0x34")]
	public Transform[] trailSpawnPos;

	[Token(Token = "0x4006A40")]
	[FieldOffset(Offset = "0x38")]
	public Transform hornPlayPos;

	[Token(Token = "0x4006A41")]
	[FieldOffset(Offset = "0x3C")]
	private List<int> DFKLDJGEJDE;

	[Token(Token = "0x4006A42")]
	[FieldOffset(Offset = "0x40")]
	protected List<int> NNPAMCIOGNJ;

	[Token(Token = "0x4006A43")]
	[FieldOffset(Offset = "0x44")]
	private bool LLCOBGHCBPC;

	[Token(Token = "0x4006A44")]
	[FieldOffset(Offset = "0x48")]
	private ICJLIMLLBGE CFAOJIFIONJ;

	[Token(Token = "0x4006A45")]
	[FieldOffset(Offset = "0x4C")]
	private Coroutine CJECHINGNGA;

	[Token(Token = "0x4006A46")]
	[FieldOffset(Offset = "0x50")]
	private float KBNBFAJJBHJ;

	[Token(Token = "0x4006A47")]
	[FieldOffset(Offset = "0x54")]
	private float KGCABKEJELF;

	[Token(Token = "0x4006A48")]
	[FieldOffset(Offset = "0x58")]
	private int LPHAMEJNHCP;

	[Token(Token = "0x4006A49")]
	[FieldOffset(Offset = "0x5C")]
	private int OPNGHAMBLJH;

	[Token(Token = "0x4006A4A")]
	[FieldOffset(Offset = "0x60")]
	private bool OJAFEKLJJLK;

	[Token(Token = "0x4006A4B")]
	[FieldOffset(Offset = "0x61")]
	private bool NPNGLOGMAHO;

	[Token(Token = "0x4006A4C")]
	[FieldOffset(Offset = "0x64")]
	private List<TrailRenderer> FMGLJOMDKNK;

	[Token(Token = "0x4006A4D")]
	[FieldOffset(Offset = "0x68")]
	private List<HBJABBMEKJA> MBKFGNFAAOJ;

	[Token(Token = "0x17000879")]
	private bool OPMGNCPJPFL
	{
		[Token(Token = "0x6006456")]
		[Address(RVA = "0x26EB898", Offset = "0x26EB898", VA = "0x26EB898")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700087A")]
	public bool ABCDIOFOCFE
	{
		[Token(Token = "0x6006457")]
		[Address(RVA = "0x26EB968", Offset = "0x26EB968", VA = "0x26EB968")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006455")]
	[Address(RVA = "0x26EB7C4", Offset = "0x26EB7C4", VA = "0x26EB7C4")]
	public VehicleEffect()
	{
	}

	[Token(Token = "0x6006458")]
	[Address(RVA = "0x26EBA38", Offset = "0x26EBA38", VA = "0x26EBA38")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006459")]
	[Address(RVA = "0x26EC374", Offset = "0x26EC374", VA = "0x26EC374")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600645A")]
	[Address(RVA = "0x26EC3F0", Offset = "0x26EC3F0", VA = "0x26EC3F0")]
	private void GCCLLNKMPEK()
	{
	}

	[Token(Token = "0x600645B")]
	[Address(RVA = "0x26EC5F8", Offset = "0x26EC5F8", VA = "0x26EC5F8")]
	private ICJLIMLLBGE BPELLFOMCBK()
	{
		return default(ICJLIMLLBGE);
	}

	[Token(Token = "0x600645C")]
	[Address(RVA = "0x26EC764", Offset = "0x26EC764", VA = "0x26EC764")]
	private bool INGPAOGJBIH()
	{
		return default(bool);
	}

	[Token(Token = "0x600645D")]
	[Address(RVA = "0x26ECE84", Offset = "0x26ECE84", VA = "0x26ECE84")]
	private bool DLPFEMBMPPJ()
	{
		return default(bool);
	}

	[Token(Token = "0x600645E")]
	[Address(RVA = "0x26ECFE8", Offset = "0x26ECFE8", VA = "0x26ECFE8")]
	private IEnumerator PALFFFIPEJC()
	{
		return null;
	}

	[Token(Token = "0x600645F")]
	[Address(RVA = "0x26ED17C", Offset = "0x26ED17C", VA = "0x26ED17C")]
	private void GKDCICKNKDA()
	{
	}

	[Token(Token = "0x6006460")]
	[Address(RVA = "0x26ED0B4", Offset = "0x26ED0B4", VA = "0x26ED0B4")]
	private void JFEHCNNCOHB()
	{
	}

	[Token(Token = "0x6006461")]
	[Address(RVA = "0x26ED3C0", Offset = "0x26ED3C0", VA = "0x26ED3C0")]
	private void FBKIJOJGGBN(ParticleSystem GIHMAEJEIPE)
	{
	}

	[Token(Token = "0x6006462")]
	[Address(RVA = "0x26EC53C", Offset = "0x26EC53C", VA = "0x26EC53C")]
	private void AMMBLMJLKAG()
	{
	}

	[Token(Token = "0x6006463")]
	[Address(RVA = "0x26ED844", Offset = "0x26ED844", VA = "0x26ED844")]
	private void NPPHMMAMDLO()
	{
	}

	[Token(Token = "0x6006464")]
	[Address(RVA = "0x26EE238", Offset = "0x26EE238", VA = "0x26EE238")]
	private void HOFIPOAEGEM()
	{
	}

	[Token(Token = "0x6006465")]
	[Address(RVA = "0x26EE470", Offset = "0x26EE470", VA = "0x26EE470")]
	public void SetVisible(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x6006466")]
	[Address(RVA = "0x26EE948", Offset = "0x26EE948", VA = "0x26EE948")]
	public void OnTriggerEnter(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6006467")]
	[Address(RVA = "0x26EEBB8", Offset = "0x26EEBB8", VA = "0x26EEBB8")]
	public void OnTriggerExit(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6006468")]
	[Address(RVA = "0x26EE810", Offset = "0x26EE810", VA = "0x26EE810")]
	private void GHJFNHGGCBK()
	{
	}

	[Token(Token = "0x6006469")]
	[Address(RVA = "0x26EF1B8", Offset = "0x26EF1B8", VA = "0x26EF1B8")]
	private ResourceID LJNBBKENHHH()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600646A")]
	[Address(RVA = "0x26EE624", Offset = "0x26EE624", VA = "0x26EE624")]
	private void HJEEGODJHGP()
	{
	}

	[Token(Token = "0x600646B")]
	[Address(RVA = "0x26EF2E4", Offset = "0x26EF2E4", VA = "0x26EF2E4")]
	private ResourceID IBNPDGHLKHD()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600646C")]
	[Address(RVA = "0x26EED88", Offset = "0x26EED88", VA = "0x26EED88")]
	private void DBNELIKKOKM(ref GameObject FHHBLJICHHL, Func<ResourceID> CDGMIPAIAHO, bool ODOEHEHNJOG, Transform PHLFBBIAEFE)
	{
	}

	[Token(Token = "0x600646D")]
	[Address(RVA = "0x26EF438", Offset = "0x26EF438", VA = "0x26EF438")]
	public void UpdateWaterEffects(bool JIPBFEBACIN, float NKPFEBMAAKP)
	{
	}

	[Token(Token = "0x600646E")]
	[Address(RVA = "0x26ED594", Offset = "0x26ED594", VA = "0x26ED594")]
	private bool POKPMEELBEO()
	{
		return default(bool);
	}

	[Token(Token = "0x600646F")]
	[Address(RVA = "0x26EF65C", Offset = "0x26EF65C", VA = "0x26EF65C")]
	public void PlayHorn(bool KENDCFNPDCE)
	{
	}
}
