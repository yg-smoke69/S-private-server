using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using WwiseGameSyncs;
using WwiseGameSyncs.Switch;

namespace COW.GamePlay;

[Token(Token = "0x20003FE")]
internal class PlayerAudioComponent : MonoBehaviour
{
	[Token(Token = "0x4003A36")]
	[FieldOffset(Offset = "0xC")]
	private Player AHJBMLIHBLE;

	[Token(Token = "0x4003A37")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Timer> EHDLLNACKJH;

	[Token(Token = "0x4003A38")]
	[FieldOffset(Offset = "0x14")]
	private int LIICBICECLD;

	[Token(Token = "0x4003A39")]
	[FieldOffset(Offset = "0x18")]
	private List<ResourceID> HEKKKIABJIE;

	[Token(Token = "0x4003A3A")]
	[FieldOffset(Offset = "0x1C")]
	private int JPIFNDHNOCJ;

	[Token(Token = "0x4003A3B")]
	[FieldOffset(Offset = "0x20")]
	private List<ResourceID> DKBOGJIENAM;

	[Token(Token = "0x4003A3C")]
	[FieldOffset(Offset = "0x24")]
	private int EMIBBOBFLBF;

	[Token(Token = "0x4003A3D")]
	[FieldOffset(Offset = "0x28")]
	private List<ResourceID> JLILOGJNOLD;

	[Token(Token = "0x4003A3E")]
	[FieldOffset(Offset = "0x2C")]
	private int JPLOELFGMCE;

	[Token(Token = "0x4003A3F")]
	[FieldOffset(Offset = "0x30")]
	private List<ResourceID> LAHPHHEDIDO;

	[Token(Token = "0x4003A40")]
	[FieldOffset(Offset = "0x34")]
	private List<ResourceID> IMLOIFNHGGJ;

	[Token(Token = "0x4003A41")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Dictionary<Player.GHCOKFDGCNF, Material_List> BeneathFeetToSurface;

	[Token(Token = "0x4003A42")]
	[FieldOffset(Offset = "0x38")]
	private float NNMGEHIMMFK;

	[Token(Token = "0x60012D3")]
	[Address(RVA = "0x14DAFE0", Offset = "0x14DAFE0", VA = "0x14DAFE0")]
	public PlayerAudioComponent()
	{
	}

	[Token(Token = "0x60012D4")]
	[Address(RVA = "0x14DB804", Offset = "0x14DB804", VA = "0x14DB804")]
	public void Init(Player FIMNKGABILM)
	{
	}

	[Token(Token = "0x60012D5")]
	[Address(RVA = "0x14DB864", Offset = "0x14DB864", VA = "0x14DB864")]
	private ResourceID ADAFCMMFJFO(List<ResourceID> NCJOJCLMELN, int BLEAICPKPGL = 0)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x14DBA1C", Offset = "0x14DBA1C", VA = "0x14DBA1C")]
	public void PlaySwimSound(bool GGDMHHBMCGJ)
	{
	}

	[Token(Token = "0x60012D7")]
	[Address(RVA = "0x14DC1FC", Offset = "0x14DC1FC", VA = "0x14DC1FC")]
	private SwitchBase MAEIMJOMONL(bool MNDJDMOMDEM = false)
	{
		return null;
	}

	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x14DC508", Offset = "0x14DC508", VA = "0x14DC508")]
	private void NKOAJCAFHCJ()
	{
	}

	[Token(Token = "0x60012D9")]
	[Address(RVA = "0x14DC83C", Offset = "0x14DC83C", VA = "0x14DC83C")]
	private void DBGKPFDHELC()
	{
	}

	[Token(Token = "0x60012DA")]
	[Address(RVA = "0x14DCBA8", Offset = "0x14DCBA8", VA = "0x14DCBA8")]
	public void PlayStepSound(AnimationEvent BNPKFJFHFOL)
	{
	}

	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x14DDBB0", Offset = "0x14DDBB0", VA = "0x14DDBB0")]
	public void PlayJumpSound()
	{
	}

	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x14DDE80", Offset = "0x14DDE80", VA = "0x14DDE80")]
	public void PlayLandSound()
	{
	}

	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x14DE1B0", Offset = "0x14DE1B0", VA = "0x14DE1B0")]
	public void PlayChangeWeaponSound()
	{
	}

	[Token(Token = "0x60012DE")]
	[Address(RVA = "0x14DE228", Offset = "0x14DE228", VA = "0x14DE228")]
	public void PlayCrawlSound(AnimationEvent BNPKFJFHFOL)
	{
	}

	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x14DE49C", Offset = "0x14DE49C", VA = "0x14DE49C")]
	public void PlayClimbSound()
	{
	}

	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x14DE61C", Offset = "0x14DE61C", VA = "0x14DE61C")]
	public void PlayPaintSound()
	{
	}

	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x14DE8A4", Offset = "0x14DE8A4", VA = "0x14DE8A4")]
	public bool CheckIsNeedPlaySound(string IDLNOOONPIC, float AOFPNOHDOJI)
	{
		return default(bool);
	}

	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x14DEC1C", Offset = "0x14DEC1C", VA = "0x14DEC1C")]
	public void PlayImpactSound(int MHMMBOMKKAG = -1)
	{
	}

	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x14DEE8C", Offset = "0x14DEE8C", VA = "0x14DEE8C")]
	public void PlayInjuredSound(int JLKLMFHFHFF, int MHMMBOMKKAG = -1, int MLEMFMHIJGO = 0)
	{
	}

	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x14DFD5C", Offset = "0x14DFD5C", VA = "0x14DFD5C")]
	private SwitchBase NCECJINAFGC(DBNMCJLEFJI PPDNNNBLFJA)
	{
		return null;
	}

	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x14DFF64", Offset = "0x14DFF64", VA = "0x14DFF64")]
	public void PlayHitSound(GPBDEDFKJNA.ENBHOKKHLPG BHPHDBLOLFF, DBNMCJLEFJI PPDNNNBLFJA, OOIPMACFIFL OGPDJFDKDDA)
	{
	}

	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x14E0404", Offset = "0x14E0404", VA = "0x14E0404")]
	public void PlayPullBoltSound()
	{
	}

	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x14DD7D8", Offset = "0x14DD7D8", VA = "0x14DD7D8")]
	private void FFPLJLBDNDK()
	{
	}

	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x14DF8F0", Offset = "0x14DF8F0", VA = "0x14DF8F0")]
	public void PlayWhizBySound(Vector3 AHMEIFIGKFB)
	{
	}

	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x14E0608", Offset = "0x14E0608", VA = "0x14E0608")]
	protected void OKCOHJDADLH(string GGLPFAAOPPF)
	{
	}

	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x14E0830", Offset = "0x14E0830", VA = "0x14E0830")]
	public void PlayePulseMedGunWhizBySound(Vector3 AHMEIFIGKFB, bool NACIDIKBIBB, bool PDEGCOGICNA)
	{
	}
}
