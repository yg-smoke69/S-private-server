using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000D25")]
public class VehicleJumpController : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4006A70")]
	[FieldOffset(Offset = "0xC")]
	public Rigidbody m_Rigid;

	[Token(Token = "0x4006A71")]
	[FieldOffset(Offset = "0x10")]
	public RCC_WheelCollider[] m_Wheels;

	[Token(Token = "0x4006A72")]
	[FieldOffset(Offset = "0x14")]
	public CarJumpParam m_Param;

	[Token(Token = "0x4006A73")]
	[FieldOffset(Offset = "0x18")]
	public float m_BoostDirYOffSet;

	[Token(Token = "0x4006A74")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 EKHJNPPHCGE;

	[Token(Token = "0x4006A75")]
	[FieldOffset(Offset = "0x28")]
	private bool MGBMAKDLIJP;

	[Token(Token = "0x4006A76")]
	[FieldOffset(Offset = "0x2C")]
	private float MDGMGOCDDOE;

	[Token(Token = "0x4006A77")]
	[FieldOffset(Offset = "0x30")]
	private TssSdtFloat OPIIAOHFJKH;

	[Token(Token = "0x4006A78")]
	[FieldOffset(Offset = "0x34")]
	private float _003CEGGODBKCCOJ_003Ek__BackingField;

	[Token(Token = "0x4006A79")]
	[FieldOffset(Offset = "0x38")]
	private int _003CMEGBFHIODPK_003Ek__BackingField;

	[Token(Token = "0x4006A7A")]
	[FieldOffset(Offset = "0x3C")]
	private float _003COLBFLCONBOA_003Ek__BackingField;

	[Token(Token = "0x4006A7B")]
	[FieldOffset(Offset = "0x40")]
	private bool _003COLELIFPMLKG_003Ek__BackingField;

	[Token(Token = "0x4006A7C")]
	[FieldOffset(Offset = "0x44")]
	private float _003CIEAKBGMBNDI_003Ek__BackingField;

	[Token(Token = "0x4006A7D")]
	[FieldOffset(Offset = "0x48")]
	private float _003CPJFHAMMIIOF_003Ek__BackingField;

	[Token(Token = "0x4006A7E")]
	[FieldOffset(Offset = "0x4C")]
	private float _003CMPNPAOKPJAL_003Ek__BackingField;

	[Token(Token = "0x4006A7F")]
	[FieldOffset(Offset = "0x50")]
	private float _003CBFGJMNACHKH_003Ek__BackingField;

	[Token(Token = "0x4006A80")]
	[FieldOffset(Offset = "0x54")]
	private bool GAPDNODLCJN;

	[Token(Token = "0x4006A81")]
	[FieldOffset(Offset = "0x58")]
	private List<WheelColliderInterface> BGCLDKHMCLN;

	[Token(Token = "0x1700087D")]
	public bool POPPEFANKLM
	{
		[Token(Token = "0x600647C")]
		[Address(RVA = "0x26EFDE8", Offset = "0x26EFDE8", VA = "0x26EFDE8", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700087E")]
	public float CICDKKFNEOC
	{
		[Token(Token = "0x600647D")]
		[Address(RVA = "0x26EFE40", Offset = "0x26EFE40", VA = "0x26EFE40", Slot = "10")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600647E")]
		[Address(RVA = "0x26EFE48", Offset = "0x26EFE48", VA = "0x26EFE48")]
		set
		{
		}
	}

	[Token(Token = "0x1700087F")]
	public VehicleControllerInfo PNHBCFIAHMJ
	{
		[Token(Token = "0x600647F")]
		[Address(RVA = "0x26EFE50", Offset = "0x26EFE50", VA = "0x26EFE50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000880")]
	public int KEGEAOIJFBP
	{
		[Token(Token = "0x6006480")]
		[Address(RVA = "0x26EFEA8", Offset = "0x26EFEA8", VA = "0x26EFEA8", Slot = "12")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006481")]
		[Address(RVA = "0x26EFEB0", Offset = "0x26EFEB0", VA = "0x26EFEB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000881")]
	public float AFCFEKMCDNN
	{
		[Token(Token = "0x6006482")]
		[Address(RVA = "0x26EFEB8", Offset = "0x26EFEB8", VA = "0x26EFEB8", Slot = "9")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6006483")]
		[Address(RVA = "0x26EFEC0", Offset = "0x26EFEC0", VA = "0x26EFEC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000882")]
	public bool FCOINGNNAEF
	{
		[Token(Token = "0x6006484")]
		[Address(RVA = "0x26EFEC8", Offset = "0x26EFEC8", VA = "0x26EFEC8", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006485")]
		[Address(RVA = "0x26EFED0", Offset = "0x26EFED0", VA = "0x26EFED0", Slot = "4")]
		set
		{
		}
	}

	[Token(Token = "0x17000883")]
	public float OOFJEHEFMNI
	{
		[Token(Token = "0x6006486")]
		[Address(RVA = "0x26EFED8", Offset = "0x26EFED8", VA = "0x26EFED8", Slot = "7")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6006487")]
		[Address(RVA = "0x26EFEE0", Offset = "0x26EFEE0", VA = "0x26EFEE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000884")]
	public float NNAHPJMINDC
	{
		[Token(Token = "0x6006488")]
		[Address(RVA = "0x26EFEE8", Offset = "0x26EFEE8", VA = "0x26EFEE8", Slot = "11")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6006489")]
		[Address(RVA = "0x26EFEF0", Offset = "0x26EFEF0", VA = "0x26EFEF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000885")]
	public Transform HHNAIAPHIHH
	{
		[Token(Token = "0x600648A")]
		[Address(RVA = "0x26EFEF8", Offset = "0x26EFEF8", VA = "0x26EFEF8", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000886")]
	public float LMNBBBCKMGB
	{
		[Token(Token = "0x600648B")]
		[Address(RVA = "0x26EFF50", Offset = "0x26EFF50", VA = "0x26EFF50", Slot = "8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600648C")]
		[Address(RVA = "0x26EFF58", Offset = "0x26EFF58", VA = "0x26EFF58")]
		set
		{
		}
	}

	[Token(Token = "0x17000887")]
	public float APPHBHNLHPJ
	{
		[Token(Token = "0x600648E")]
		[Address(RVA = "0x26EFF68", Offset = "0x26EFF68", VA = "0x26EFF68", Slot = "14")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600648D")]
		[Address(RVA = "0x26EFF60", Offset = "0x26EFF60", VA = "0x26EFF60")]
		set
		{
		}
	}

	[Token(Token = "0x17000888")]
	public bool ABCDIOFOCFE
	{
		[Token(Token = "0x6006492")]
		[Address(RVA = "0x26F009C", Offset = "0x26F009C", VA = "0x26F009C", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006493")]
		[Address(RVA = "0x26F00F4", Offset = "0x26F00F4", VA = "0x26F00F4", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x17000889")]
	public List<WheelColliderInterface> PPBKKLIDJFL
	{
		[Token(Token = "0x6006494")]
		[Address(RVA = "0x26F0154", Offset = "0x26F0154", VA = "0x26F0154")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088A")]
	public bool JCAPJNOALJN
	{
		[Token(Token = "0x6006497")]
		[Address(RVA = "0x26F0558", Offset = "0x26F0558", VA = "0x26F0558", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600647B")]
	[Address(RVA = "0x26EFD40", Offset = "0x26EFD40", VA = "0x26EFD40")]
	public VehicleJumpController()
	{
	}

	[Token(Token = "0x600648F")]
	[Address(RVA = "0x26EFF70", Offset = "0x26EFF70", VA = "0x26EFF70", Slot = "15")]
	public float CaculateVehicleRevs()
	{
		return default(float);
	}

	[Token(Token = "0x6006490")]
	[Address(RVA = "0x26EFFC8", Offset = "0x26EFFC8", VA = "0x26EFFC8", Slot = "36")]
	public int GetWheelType(GameObject OMDFNKNJDII)
	{
		return default(int);
	}

	[Token(Token = "0x6006491")]
	[Address(RVA = "0x26F002C", Offset = "0x26F002C", VA = "0x26F002C", Slot = "39")]
	public void SetJumpHeightRate(float BOGINBBGDIB)
	{
	}

	[Token(Token = "0x6006495")]
	[Address(RVA = "0x26F02DC", Offset = "0x26F02DC", VA = "0x26F02DC", Slot = "37")]
	public void StartBoost(float POFLLMODKII, float GKJAGJKJMFA, float EGHHKPCJNCH)
	{
	}

	[Token(Token = "0x6006496")]
	[Address(RVA = "0x26F0504", Offset = "0x26F0504", VA = "0x26F0504", Slot = "38")]
	public void StopBoost()
	{
	}

	[Token(Token = "0x6006498")]
	[Address(RVA = "0x26F05B0", Offset = "0x26F05B0", VA = "0x26F05B0", Slot = "21")]
	public void SetControllerInfo(VehicleControllerInfo HBKEFIALNGI)
	{
	}

	[Token(Token = "0x6006499")]
	[Address(RVA = "0x26F060C", Offset = "0x26F060C", VA = "0x26F060C", Slot = "24")]
	public void SetDriverSpeedScale(float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x600649A")]
	[Address(RVA = "0x26F0668", Offset = "0x26F0668", VA = "0x26F0668", Slot = "25")]
	public float GetDriverSpeedScale()
	{
		return default(float);
	}

	[Token(Token = "0x600649B")]
	[Address(RVA = "0x26F06C0", Offset = "0x26F06C0", VA = "0x26F06C0", Slot = "23")]
	public void SetMaxSpeedScale(float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x600649C")]
	[Address(RVA = "0x26F071C", Offset = "0x26F071C", VA = "0x26F071C", Slot = "40")]
	public void SetHightSpeedSteerAngleRate(float BOGINBBGDIB)
	{
	}

	[Token(Token = "0x600649D")]
	[Address(RVA = "0x26F0778", Offset = "0x26F0778", VA = "0x26F0778", Slot = "41")]
	public void SetEngineTorqueRate(float BOGINBBGDIB)
	{
	}

	[Token(Token = "0x600649E")]
	[Address(RVA = "0x26F07D4", Offset = "0x26F07D4", VA = "0x26F07D4", Slot = "42")]
	public void SetBrakeTorqueRate(float BOGINBBGDIB)
	{
	}

	[Token(Token = "0x600649F")]
	[Address(RVA = "0x26F0830", Offset = "0x26F0830", VA = "0x26F0830", Slot = "22")]
	public void SetVehicleEnable(bool MCDIDHODHLN, bool BIHGBIOCGAJ = false)
	{
	}

	[Token(Token = "0x60064A0")]
	[Address(RVA = "0x26F08A0", Offset = "0x26F08A0", VA = "0x26F08A0", Slot = "35")]
	public void StartEngine()
	{
	}

	[Token(Token = "0x60064A1")]
	[Address(RVA = "0x26F0BE8", Offset = "0x26F0BE8", VA = "0x26F0BE8", Slot = "34")]
	public void KillEngine()
	{
	}

	[Token(Token = "0x60064A2")]
	[Address(RVA = "0x26F0C3C", Offset = "0x26F0C3C", VA = "0x26F0C3C", Slot = "28")]
	public void UpdateVehicleSpeed(float CMAMCEPJLDH, float PHENGJDKFDN)
	{
	}

	[Token(Token = "0x60064A3")]
	[Address(RVA = "0x26F0CAC", Offset = "0x26F0CAC", VA = "0x26F0CAC", Slot = "29")]
	public void UpdateVehicleSteerAngle(float DJDPAPJCLPF)
	{
	}

	[Token(Token = "0x60064A4")]
	[Address(RVA = "0x26F0D08", Offset = "0x26F0D08", VA = "0x26F0D08", Slot = "31")]
	public void VehicleLasyUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60064A5")]
	[Address(RVA = "0x26F0E94", Offset = "0x26F0E94", VA = "0x26F0E94", Slot = "30")]
	public void VehicleLazyFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60064A6")]
	[Address(RVA = "0x26F1198", Offset = "0x26F1198", VA = "0x26F1198", Slot = "32")]
	public void VehicleUpdateInput(bool JIPBFEBACIN, bool KPIDIFMEDGA, Vector3 GDFOEABIGBA)
	{
	}

	[Token(Token = "0x60064A7")]
	[Address(RVA = "0x26F124C", Offset = "0x26F124C", VA = "0x26F124C", Slot = "33")]
	public void VehicleUpdateInput(float JIPBFEBACIN, float KPIDIFMEDGA, Vector3 GDFOEABIGBA)
	{
	}

	[Token(Token = "0x60064A8")]
	[Address(RVA = "0x26F09BC", Offset = "0x26F09BC", VA = "0x26F09BC")]
	private void IMIFFHCBFKC()
	{
	}

	[Token(Token = "0x60064A9")]
	[Address(RVA = "0x26F12F4", Offset = "0x26F12F4", VA = "0x26F12F4")]
	private void IHEINPJAELO(Vector3 GDFOEABIGBA)
	{
	}

	[Token(Token = "0x60064AA")]
	[Address(RVA = "0x26F14F0", Offset = "0x26F14F0", VA = "0x26F14F0", Slot = "20")]
	public void BindVehicleSkin(VehicleSkinInfoBase IDOELFCJOGP)
	{
	}

	[Token(Token = "0x60064AB")]
	[Address(RVA = "0x26F154C", Offset = "0x26F154C", VA = "0x26F154C", Slot = "26")]
	public void LockMaxSpeed(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x60064AC")]
	[Address(RVA = "0x26F15A8", Offset = "0x26F15A8", VA = "0x26F15A8", Slot = "27")]
	public void UnLockMaxSpeed()
	{
	}

	[Token(Token = "0x60064AD")]
	[Address(RVA = "0x26F15FC", Offset = "0x26F15FC", VA = "0x26F15FC", Slot = "43")]
	public void ForceStop()
	{
	}
}
