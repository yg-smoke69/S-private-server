using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000CFE")]
public class ParachutejumpCarController : MonoBehaviour, _Attribute
{
	[Token(Token = "0x2000CFF")]
	public enum GFGIBNBHKMA
	{
		[Token(Token = "0x4006936")]
		None,
		[Token(Token = "0x4006937")]
		OnBoard,
		[Token(Token = "0x4006938")]
		SkyDiving,
		[Token(Token = "0x4006939")]
		Parachuting
	}

	[Token(Token = "0x2000D00")]
	public delegate void LCDOKLMFMKC(GFGIBNBHKMA OMOPEEPBABG);

	[Token(Token = "0x2000D01")]
	public delegate void ABLEHFCOAJL(GFGIBNBHKMA OMOPEEPBABG, float OPKNJGBDOBB, float OMAFEKBHOAA);

	[Token(Token = "0x400691E")]
	[FieldOffset(Offset = "0xC")]
	public Transform VehicleMeshBody;

	[Token(Token = "0x400691F")]
	[FieldOffset(Offset = "0x10")]
	protected Rigidbody FLEIFDCPEDD;

	[Token(Token = "0x4006920")]
	[FieldOffset(Offset = "0x14")]
	public GFGIBNBHKMA CurKinematicState;

	[Token(Token = "0x4006921")]
	[FieldOffset(Offset = "0x18")]
	public LCDOKLMFMKC onParachuteStateChange;

	[Token(Token = "0x4006922")]
	[FieldOffset(Offset = "0x1C")]
	public ABLEHFCOAJL onParachuteStateTick;

	[Token(Token = "0x4006923")]
	[FieldOffset(Offset = "0x20")]
	private bool _003COLELIFPMLKG_003Ek__BackingField;

	[Token(Token = "0x4006924")]
	[FieldOffset(Offset = "0x24")]
	private float _003CIEAKBGMBNDI_003Ek__BackingField;

	[Token(Token = "0x4006925")]
	[FieldOffset(Offset = "0x28")]
	private float _003CMPNPAOKPJAL_003Ek__BackingField;

	[Token(Token = "0x4006926")]
	[FieldOffset(Offset = "0x2C")]
	private float _003COLBFLCONBOA_003Ek__BackingField;

	[Token(Token = "0x4006927")]
	[FieldOffset(Offset = "0x30")]
	private float _003CEGGODBKCCOJ_003Ek__BackingField;

	[Token(Token = "0x4006928")]
	[FieldOffset(Offset = "0x34")]
	private float _003CPJFHAMMIIOF_003Ek__BackingField;

	[Token(Token = "0x4006929")]
	[FieldOffset(Offset = "0x38")]
	private int _003CMEGBFHIODPK_003Ek__BackingField;

	[Token(Token = "0x400692A")]
	[FieldOffset(Offset = "0x3C")]
	private bool _003CFLFOIJMNEHJ_003Ek__BackingField;

	[Token(Token = "0x400692B")]
	[FieldOffset(Offset = "0x40")]
	private float _003CBFGJMNACHKH_003Ek__BackingField;

	[Token(Token = "0x400692C")]
	[FieldOffset(Offset = "0x44")]
	private bool GAPDNODLCJN;

	[Token(Token = "0x400692D")]
	[FieldOffset(Offset = "0x48")]
	private Transform _003CNNLMCABLOJM_003Ek__BackingField;

	[Token(Token = "0x400692E")]
	[FieldOffset(Offset = "0x4C")]
	private VehicleControllerInfo _003CJFKPKNDKHOI_003Ek__BackingField;

	[Token(Token = "0x400692F")]
	[FieldOffset(Offset = "0x50")]
	private bool PMFAOLKAGGE;

	[Token(Token = "0x4006930")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 NDBHAFGCKJC;

	[Token(Token = "0x4006931")]
	[FieldOffset(Offset = "0x60")]
	private float JNGPGBOKOIH;

	[Token(Token = "0x4006932")]
	[FieldOffset(Offset = "0x64")]
	private float IKDLDDAOOHM;

	[Token(Token = "0x4006933")]
	[FieldOffset(Offset = "0x68")]
	private float ODJDCENGJLJ;

	[Token(Token = "0x4006934")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 GFJJOEJMNON;

	[Token(Token = "0x17000835")]
	public bool POPPEFANKLM
	{
		[Token(Token = "0x60062B7")]
		[Address(RVA = "0xBC488C", Offset = "0xBC488C", VA = "0xBC488C", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000836")]
	public bool FCOINGNNAEF
	{
		[Token(Token = "0x60062B9")]
		[Address(RVA = "0xBC48EC", Offset = "0xBC48EC", VA = "0xBC48EC", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60062B8")]
		[Address(RVA = "0xBC48E4", Offset = "0xBC48E4", VA = "0xBC48E4", Slot = "4")]
		set
		{
		}
	}

	[Token(Token = "0x17000837")]
	public float OOFJEHEFMNI
	{
		[Token(Token = "0x60062BB")]
		[Address(RVA = "0xBC48FC", Offset = "0xBC48FC", VA = "0xBC48FC", Slot = "7")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60062BA")]
		[Address(RVA = "0xBC48F4", Offset = "0xBC48F4", VA = "0xBC48F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000838")]
	public float LMNBBBCKMGB
	{
		[Token(Token = "0x60062BD")]
		[Address(RVA = "0xBC490C", Offset = "0xBC490C", VA = "0xBC490C", Slot = "8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60062BC")]
		[Address(RVA = "0xBC4904", Offset = "0xBC4904", VA = "0xBC4904")]
		set
		{
		}
	}

	[Token(Token = "0x17000839")]
	public float AFCFEKMCDNN
	{
		[Token(Token = "0x60062BF")]
		[Address(RVA = "0xBC491C", Offset = "0xBC491C", VA = "0xBC491C", Slot = "9")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60062BE")]
		[Address(RVA = "0xBC4914", Offset = "0xBC4914", VA = "0xBC4914")]
		set
		{
		}
	}

	[Token(Token = "0x1700083A")]
	public float CICDKKFNEOC
	{
		[Token(Token = "0x60062C1")]
		[Address(RVA = "0xBC492C", Offset = "0xBC492C", VA = "0xBC492C", Slot = "10")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60062C0")]
		[Address(RVA = "0xBC4924", Offset = "0xBC4924", VA = "0xBC4924")]
		set
		{
		}
	}

	[Token(Token = "0x1700083B")]
	public float NNAHPJMINDC
	{
		[Token(Token = "0x60062C3")]
		[Address(RVA = "0xBC493C", Offset = "0xBC493C", VA = "0xBC493C", Slot = "11")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60062C2")]
		[Address(RVA = "0xBC4934", Offset = "0xBC4934", VA = "0xBC4934")]
		set
		{
		}
	}

	[Token(Token = "0x1700083C")]
	public int KEGEAOIJFBP
	{
		[Token(Token = "0x60062C5")]
		[Address(RVA = "0xBC494C", Offset = "0xBC494C", VA = "0xBC494C", Slot = "12")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60062C4")]
		[Address(RVA = "0xBC4944", Offset = "0xBC4944", VA = "0xBC4944")]
		set
		{
		}
	}

	[Token(Token = "0x1700083D")]
	public bool JCAPJNOALJN
	{
		[Token(Token = "0x60062C7")]
		[Address(RVA = "0xBC495C", Offset = "0xBC495C", VA = "0xBC495C", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60062C6")]
		[Address(RVA = "0xBC4954", Offset = "0xBC4954", VA = "0xBC4954")]
		set
		{
		}
	}

	[Token(Token = "0x1700083E")]
	public float APPHBHNLHPJ
	{
		[Token(Token = "0x60062C9")]
		[Address(RVA = "0xBC496C", Offset = "0xBC496C", VA = "0xBC496C", Slot = "14")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60062C8")]
		[Address(RVA = "0xBC4964", Offset = "0xBC4964", VA = "0xBC4964")]
		set
		{
		}
	}

	[Token(Token = "0x1700083F")]
	public bool ABCDIOFOCFE
	{
		[Token(Token = "0x60062CC")]
		[Address(RVA = "0xBC4A28", Offset = "0xBC4A28", VA = "0xBC4A28", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60062CD")]
		[Address(RVA = "0xBC4A80", Offset = "0xBC4A80", VA = "0xBC4A80", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x17000840")]
	public Transform HHNAIAPHIHH
	{
		[Token(Token = "0x60062CF")]
		[Address(RVA = "0xBC4AE8", Offset = "0xBC4AE8", VA = "0xBC4AE8", Slot = "18")]
		get
		{
			return null;
		}
		[Token(Token = "0x60062CE")]
		[Address(RVA = "0xBC4AE0", Offset = "0xBC4AE0", VA = "0xBC4AE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000841")]
	public VehicleControllerInfo PNHBCFIAHMJ
	{
		[Token(Token = "0x60062D1")]
		[Address(RVA = "0xBC4AF8", Offset = "0xBC4AF8", VA = "0xBC4AF8", Slot = "19")]
		get
		{
			return null;
		}
		[Token(Token = "0x60062D0")]
		[Address(RVA = "0xBC4AF0", Offset = "0xBC4AF0", VA = "0xBC4AF0")]
		set
		{
		}
	}

	[Token(Token = "0x60062B6")]
	[Address(RVA = "0xBC47C4", Offset = "0xBC47C4", VA = "0xBC47C4")]
	public ParachutejumpCarController()
	{
	}

	[Token(Token = "0x60062CA")]
	[Address(RVA = "0xBC4974", Offset = "0xBC4974", VA = "0xBC4974", Slot = "15")]
	public float CaculateVehicleRevs()
	{
		return default(float);
	}

	[Token(Token = "0x60062CB")]
	[Address(RVA = "0xBC49CC", Offset = "0xBC49CC", VA = "0xBC49CC", Slot = "39")]
	public void SetJumpHeightRate(float BOGINBBGDIB)
	{
	}

	[Token(Token = "0x60062D2")]
	[Address(RVA = "0xBC4B00", Offset = "0xBC4B00", VA = "0xBC4B00", Slot = "20")]
	public void BindVehicleSkin(VehicleSkinInfoBase IDOELFCJOGP)
	{
	}

	[Token(Token = "0x60062D3")]
	[Address(RVA = "0xBC4B5C", Offset = "0xBC4B5C", VA = "0xBC4B5C", Slot = "21")]
	public void SetControllerInfo(VehicleControllerInfo HBKEFIALNGI)
	{
	}

	[Token(Token = "0x60062D4")]
	[Address(RVA = "0xBC4BB8", Offset = "0xBC4BB8", VA = "0xBC4BB8", Slot = "22")]
	public void SetVehicleEnable(bool MCDIDHODHLN, bool BIHGBIOCGAJ = false)
	{
	}

	[Token(Token = "0x60062D5")]
	[Address(RVA = "0xBC4C28", Offset = "0xBC4C28", VA = "0xBC4C28", Slot = "23")]
	public void SetMaxSpeedScale(float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x60062D6")]
	[Address(RVA = "0xBC4C84", Offset = "0xBC4C84", VA = "0xBC4C84", Slot = "40")]
	public void SetHightSpeedSteerAngleRate(float BOGINBBGDIB)
	{
	}

	[Token(Token = "0x60062D7")]
	[Address(RVA = "0xBC4CE0", Offset = "0xBC4CE0", VA = "0xBC4CE0", Slot = "41")]
	public void SetEngineTorqueRate(float BOGINBBGDIB)
	{
	}

	[Token(Token = "0x60062D8")]
	[Address(RVA = "0xBC4D3C", Offset = "0xBC4D3C", VA = "0xBC4D3C", Slot = "42")]
	public void SetBrakeTorqueRate(float BOGINBBGDIB)
	{
	}

	[Token(Token = "0x60062D9")]
	[Address(RVA = "0xBC4D98", Offset = "0xBC4D98", VA = "0xBC4D98", Slot = "24")]
	public void SetDriverSpeedScale(float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x60062DA")]
	[Address(RVA = "0xBC4DF4", Offset = "0xBC4DF4", VA = "0xBC4DF4", Slot = "25")]
	public float GetDriverSpeedScale()
	{
		return default(float);
	}

	[Token(Token = "0x60062DB")]
	[Address(RVA = "0xBC4E4C", Offset = "0xBC4E4C", VA = "0xBC4E4C", Slot = "28")]
	public void UpdateVehicleSpeed(float CMAMCEPJLDH, float PHENGJDKFDN)
	{
	}

	[Token(Token = "0x60062DC")]
	[Address(RVA = "0xBC4EBC", Offset = "0xBC4EBC", VA = "0xBC4EBC", Slot = "29")]
	public void UpdateVehicleSteerAngle(float DJDPAPJCLPF)
	{
	}

	[Token(Token = "0x60062DD")]
	[Address(RVA = "0xBC4F18", Offset = "0xBC4F18", VA = "0xBC4F18", Slot = "31")]
	public void VehicleLasyUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60062DE")]
	[Address(RVA = "0xBC4F88", Offset = "0xBC4F88", VA = "0xBC4F88", Slot = "34")]
	public void KillEngine()
	{
	}

	[Token(Token = "0x60062DF")]
	[Address(RVA = "0xBC4FDC", Offset = "0xBC4FDC", VA = "0xBC4FDC", Slot = "36")]
	public int GetWheelType(GameObject OMDFNKNJDII)
	{
		return default(int);
	}

	[Token(Token = "0x60062E0")]
	[Address(RVA = "0xBC5040", Offset = "0xBC5040", VA = "0xBC5040", Slot = "37")]
	public void StartBoost(float POFLLMODKII, float GKJAGJKJMFA, float EGHHKPCJNCH)
	{
	}

	[Token(Token = "0x60062E1")]
	[Address(RVA = "0xBC50C4", Offset = "0xBC50C4", VA = "0xBC50C4", Slot = "38")]
	public void StopBoost()
	{
	}

	[Token(Token = "0x60062E2")]
	[Address(RVA = "0xBC5118", Offset = "0xBC5118", VA = "0xBC5118")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60062E3")]
	[Address(RVA = "0xBC51C8", Offset = "0xBC51C8", VA = "0xBC51C8", Slot = "35")]
	public void StartEngine()
	{
	}

	[Token(Token = "0x60062E4")]
	[Address(RVA = "0xBC52EC", Offset = "0xBC52EC", VA = "0xBC52EC", Slot = "32")]
	public void VehicleUpdateInput(bool JIPBFEBACIN, bool KPIDIFMEDGA, Vector3 GDFOEABIGBA)
	{
	}

	[Token(Token = "0x60062E5")]
	[Address(RVA = "0xBC5388", Offset = "0xBC5388", VA = "0xBC5388", Slot = "33")]
	public void VehicleUpdateInput(float JIPBFEBACIN, float KPIDIFMEDGA, Vector3 GDFOEABIGBA)
	{
	}

	[Token(Token = "0x60062E6")]
	[Address(RVA = "0xBC540C", Offset = "0xBC540C", VA = "0xBC540C")]
	public void ChangeToKinematicState(GFGIBNBHKMA NKNAAOKGNHE)
	{
	}

	[Token(Token = "0x60062E7")]
	[Address(RVA = "0xBC56C4", Offset = "0xBC56C4", VA = "0xBC56C4", Slot = "30")]
	public void VehicleLazyFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60062E8")]
	[Address(RVA = "0xBC579C", Offset = "0xBC579C", VA = "0xBC579C")]
	public void FixedUpdateOnBoard(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60062E9")]
	[Address(RVA = "0xBC5844", Offset = "0xBC5844", VA = "0xBC5844")]
	public void FixdUpdateSkiDiving(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60062EA")]
	[Address(RVA = "0xBC5A44", Offset = "0xBC5A44", VA = "0xBC5A44")]
	public void FixdUpdateParachuting(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60062EB")]
	[Address(RVA = "0xBC60EC", Offset = "0xBC60EC", VA = "0xBC60EC")]
	private void HFLDMIOIDAN(float OMAFEKBHOAA, float FOHALLGBNGM, float LHOPIMLJFAO, float HKKFFLDLJJN, float HMGDPJDPNIL)
	{
	}

	[Token(Token = "0x60062EC")]
	[Address(RVA = "0xBC6300", Offset = "0xBC6300", VA = "0xBC6300")]
	private void FOONMDEPEIM(float OMAFEKBHOAA, float DAFJACCAKAO)
	{
	}

	[Token(Token = "0x60062ED")]
	[Address(RVA = "0xBC68B4", Offset = "0xBC68B4", VA = "0xBC68B4", Slot = "26")]
	public void LockMaxSpeed(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x60062EE")]
	[Address(RVA = "0xBC6910", Offset = "0xBC6910", VA = "0xBC6910", Slot = "27")]
	public void UnLockMaxSpeed()
	{
	}

	[Token(Token = "0x60062EF")]
	[Address(RVA = "0xBC6964", Offset = "0xBC6964", VA = "0xBC6964", Slot = "43")]
	public void ForceStop()
	{
	}
}
