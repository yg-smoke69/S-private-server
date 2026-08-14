using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006AF")]
public class LevelTeleportDoor : BaseLevelObject
{
	[Token(Token = "0x20006B0")]
	private enum LGIBHBHKIPG
	{
		[Token(Token = "0x4004A62")]
		NONE,
		[Token(Token = "0x4004A63")]
		Acite_Show,
		[Token(Token = "0x4004A64")]
		Active_Hide,
		[Token(Token = "0x4004A65")]
		Streamer_Show,
		[Token(Token = "0x4004A66")]
		Streamer_Hide
	}

	[Token(Token = "0x4004A4A")]
	[FieldOffset(Offset = "0x74")]
	public EFNHBHILCNJ TeleportDoorType;

	[Token(Token = "0x4004A4B")]
	[FieldOffset(Offset = "0x78")]
	public BAJIKKBEEPF TeleportDoorStyle;

	[Token(Token = "0x4004A4C")]
	[FieldOffset(Offset = "0x7C")]
	public int GroupID;

	[Token(Token = "0x4004A4D")]
	[FieldOffset(Offset = "0x80")]
	public bool ProvideBuff;

	[Token(Token = "0x4004A4E")]
	[FieldOffset(Offset = "0x84")]
	public int BuffID;

	[Token(Token = "0x4004A4F")]
	[FieldOffset(Offset = "0x88")]
	public Transform[] TeleportPoints;

	[Token(Token = "0x4004A50")]
	[FieldOffset(Offset = "0x8C")]
	public float TeleportPointRadius;

	[Token(Token = "0x4004A51")]
	[FieldOffset(Offset = "0x90")]
	public string Region;

	[Token(Token = "0x4004A52")]
	[FieldOffset(Offset = "0x94")]
	public string MapGroup;

	[Token(Token = "0x4004A53")]
	[FieldOffset(Offset = "0x98")]
	public GameObject ArrowObj;

	[Token(Token = "0x4004A54")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject PairedEffect;

	[Token(Token = "0x4004A55")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject TeleportEffect;

	[Token(Token = "0x4004A56")]
	[FieldOffset(Offset = "0xA4")]
	public Collider TeleportTrigger;

	[Token(Token = "0x4004A57")]
	[FieldOffset(Offset = "0xA8")]
	private uint MMJPEGGKBLE;

	[Token(Token = "0x4004A58")]
	[FieldOffset(Offset = "0xAC")]
	private uint IGABACMKMJJ;

	[Token(Token = "0x4004A59")]
	[FieldOffset(Offset = "0xB0")]
	private TeleportDoorArrowController JKEJNCCJDFO;

	[Token(Token = "0x4004A5A")]
	[FieldOffset(Offset = "0xB4")]
	private BitArrayBoolean BFKPIFKMJNK;

	[Token(Token = "0x4004A5B")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject PLJJOPCPCMB;

	[Token(Token = "0x4004A5C")]
	[FieldOffset(Offset = "0xBC")]
	private TeleportDoor JEACJGDMCNI;

	[Token(Token = "0x4004A5D")]
	[FieldOffset(Offset = "0xC0")]
	private UIModelMatch ENJMJIBBGPF;

	[Token(Token = "0x4004A5E")]
	[FieldOffset(Offset = "0xC4")]
	private bool LEJDHCDBCGD;

	[Token(Token = "0x4004A5F")]
	[FieldOffset(Offset = "0xC5")]
	private bool EHADKDJLHBB;

	[Token(Token = "0x4004A60")]
	[FieldOffset(Offset = "0xC8")]
	public uint m_DestinationLevelObjID;

	[Token(Token = "0x17000346")]
	private BitArrayBoolean MFJKDDLLMEH
	{
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0x20D7AF8", Offset = "0x20D7AF8", VA = "0x20D7AF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000347")]
	private KEPDHPAAHGP HJLFMOLGALB
	{
		[Token(Token = "0x6002ADD")]
		[Address(RVA = "0x20D7D18", Offset = "0x20D7D18", VA = "0x20D7D18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000348")]
	private bool BMPNLNLHGFL
	{
		[Token(Token = "0x6002AF6")]
		[Address(RVA = "0x20DADC0", Offset = "0x20DADC0", VA = "0x20DADC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002ADB")]
	[Address(RVA = "0x20D7ADC", Offset = "0x20D7ADC", VA = "0x20D7ADC")]
	public LevelTeleportDoor()
	{
	}

	[Token(Token = "0x6002ADE")]
	[Address(RVA = "0x20D7E38", Offset = "0x20D7E38", VA = "0x20D7E38", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002ADF")]
	[Address(RVA = "0x20D7B5C", Offset = "0x20D7B5C", VA = "0x20D7B5C")]
	private void EKCFHJPFCGN()
	{
	}

	[Token(Token = "0x6002AE0")]
	[Address(RVA = "0x20D8154", Offset = "0x20D8154", VA = "0x20D8154", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002AE1")]
	[Address(RVA = "0x20D82E0", Offset = "0x20D82E0", VA = "0x20D82E0")]
	private void LBCHBOGLJMB()
	{
	}

	[Token(Token = "0x6002AE2")]
	[Address(RVA = "0x20D851C", Offset = "0x20D851C", VA = "0x20D851C", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002AE3")]
	[Address(RVA = "0x20D8980", Offset = "0x20D8980", VA = "0x20D8980", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002AE4")]
	[Address(RVA = "0x20D8BE0", Offset = "0x20D8BE0", VA = "0x20D8BE0", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002AE5")]
	[Address(RVA = "0x20D8C38", Offset = "0x20D8C38", VA = "0x20D8C38")]
	private void ODIMBFBENCB(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002AE6")]
	[Address(RVA = "0x20D9178", Offset = "0x20D9178", VA = "0x20D9178")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6002AE7")]
	[Address(RVA = "0x20D92CC", Offset = "0x20D92CC", VA = "0x20D92CC")]
	public bool IsParachuteTeleportDoor()
	{
		return default(bool);
	}

	[Token(Token = "0x6002AE8")]
	[Address(RVA = "0x20D9338", Offset = "0x20D9338", VA = "0x20D9338")]
	public void OnLocalPlayerEnter()
	{
	}

	[Token(Token = "0x6002AE9")]
	[Address(RVA = "0x20D94D4", Offset = "0x20D94D4", VA = "0x20D94D4")]
	public void OnLocalPlayerExit()
	{
	}

	[Token(Token = "0x6002AEA")]
	[Address(RVA = "0x20D95E0", Offset = "0x20D95E0", VA = "0x20D95E0")]
	public int GetCurHP()
	{
		return default(int);
	}

	[Token(Token = "0x6002AEB")]
	[Address(RVA = "0x20D9704", Offset = "0x20D9704", VA = "0x20D9704")]
	public void SetCurHP(int LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6002AEC")]
	[Address(RVA = "0x20D9960", Offset = "0x20D9960", VA = "0x20D9960", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x6002AED")]
	[Address(RVA = "0x20D7EDC", Offset = "0x20D7EDC", VA = "0x20D7EDC")]
	private void FCPGNADNEEI(LGIBHBHKIPG GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6002AEE")]
	[Address(RVA = "0x20D9B90", Offset = "0x20D9B90", VA = "0x20D9B90")]
	private void GDICILBGKIJ(LGIBHBHKIPG GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6002AEF")]
	[Address(RVA = "0x20DA0FC", Offset = "0x20DA0FC", VA = "0x20DA0FC")]
	private void GGBACBIFDCN(LGIBHBHKIPG GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6002AF0")]
	[Address(RVA = "0x20D8714", Offset = "0x20D8714", VA = "0x20D8714")]
	private void FJHIBLGIMML()
	{
	}

	[Token(Token = "0x6002AF1")]
	[Address(RVA = "0x20DA5FC", Offset = "0x20DA5FC", VA = "0x20DA5FC")]
	public void ShowTeleportEffect()
	{
	}

	[Token(Token = "0x6002AF2")]
	[Address(RVA = "0x20DAB44", Offset = "0x20DAB44", VA = "0x20DAB44")]
	public void ShowWorkshopTeleportEffect()
	{
	}

	[Token(Token = "0x6002AF3")]
	[Address(RVA = "0x20DA2EC", Offset = "0x20DA2EC", VA = "0x20DA2EC")]
	private ResourceID NLGNPFPPLHE()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002AF4")]
	[Address(RVA = "0x20DA4A8", Offset = "0x20DA4A8", VA = "0x20DA4A8")]
	private ResourceID HJNHLAOHMCA()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002AF5")]
	[Address(RVA = "0x20DAC68", Offset = "0x20DAC68", VA = "0x20DAC68")]
	private ResourceID DIMOOILGFIP(BAJIKKBEEPF PMGBACFJIHO)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002AF7")]
	[Address(RVA = "0x20DAE18", Offset = "0x20DAE18", VA = "0x20DAE18")]
	public void BecomePair(uint BCOCLAGAGGI)
	{
	}

	[Token(Token = "0x6002AF8")]
	[Address(RVA = "0x20DAF34", Offset = "0x20DAF34", VA = "0x20DAF34")]
	public void BecomeAlone()
	{
	}

	[Token(Token = "0x6002AF9")]
	[Address(RVA = "0x20DB04C", Offset = "0x20DB04C", VA = "0x20DB04C")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002AFA")]
	[Address(RVA = "0x20DB054", Offset = "0x20DB054", VA = "0x20DB054")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002AFB")]
	[Address(RVA = "0x20DB05C", Offset = "0x20DB05C", VA = "0x20DB05C")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002AFC")]
	[Address(RVA = "0x20DB064", Offset = "0x20DB064", VA = "0x20DB064")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002AFD")]
	[Address(RVA = "0x20DB06C", Offset = "0x20DB06C", VA = "0x20DB06C")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}
}
