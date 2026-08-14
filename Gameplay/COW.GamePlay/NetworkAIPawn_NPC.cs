using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000931")]
internal class NetworkAIPawn_NPC : NetworkAIPawn
{
	[Token(Token = "0x2000932")]
	public delegate void OLBBHGMMGFL(NetworkAIPawn_NPC PJOIFFLCDPM);

	[Token(Token = "0x2000933")]
	public delegate void MDPNDAANNAM(uint NLOMOJMMNHK);

	[Token(Token = "0x4005547")]
	private const float KBCNMGABAJA = 3f;

	[Token(Token = "0x4005548")]
	[FieldOffset(Offset = "0x174")]
	public OLBBHGMMGFL OnNPCTriggerEnter;

	[Token(Token = "0x4005549")]
	[FieldOffset(Offset = "0x178")]
	public MDPNDAANNAM onNPCTalkingFinished;

	[Token(Token = "0x400554A")]
	[FieldOffset(Offset = "0x17C")]
	public TextMesh m_NPCName;

	[Token(Token = "0x400554B")]
	[FieldOffset(Offset = "0x180")]
	public NPCPlayerGroupChatTrigger groupChatTrigger;

	[Token(Token = "0x400554C")]
	[FieldOffset(Offset = "0x184")]
	public Transform m_AvatarRoot;

	[Token(Token = "0x400554D")]
	[FieldOffset(Offset = "0x188")]
	public float m_SpecialAnimInterval;

	[Token(Token = "0x400554E")]
	[FieldOffset(Offset = "0x18C")]
	public LevelPhotograph m_lvlPhotograph;

	[Token(Token = "0x400554F")]
	[FieldOffset(Offset = "0x190")]
	public uint NPCID;

	[Token(Token = "0x4005550")]
	[FieldOffset(Offset = "0x194")]
	public uint NPCDataID;

	[Token(Token = "0x4005551")]
	[FieldOffset(Offset = "0x198")]
	public bool m_IsTalking;

	[Token(Token = "0x4005552")]
	[FieldOffset(Offset = "0x19C")]
	private uint ADJEIBLAABJ;

	[Token(Token = "0x4005553")]
	[FieldOffset(Offset = "0x1A0")]
	private float OONOGOFBOEB;

	[Token(Token = "0x4005554")]
	[FieldOffset(Offset = "0x1A4")]
	private AvatarManager FOGJNGDMJKJ;

	[Token(Token = "0x4005555")]
	[FieldOffset(Offset = "0x1A8")]
	private Animator KFGPIOMOLHI;

	[Token(Token = "0x4005556")]
	[FieldOffset(Offset = "0x1AC")]
	private float FMMPKGPMJNO;

	[Token(Token = "0x4005557")]
	[FieldOffset(Offset = "0x1B0")]
	private PartyNPCConfigData EMPDBHDCPFK;

	[Token(Token = "0x4005558")]
	[FieldOffset(Offset = "0x1B4")]
	private UIHudPartyNPCChatBubbleController IMFPBDKPDNG;

	[Token(Token = "0x4005559")]
	[FieldOffset(Offset = "0x1B8")]
	private Quaternion KDJEIPMPLHA;

	[Token(Token = "0x400555A")]
	[FieldOffset(Offset = "0x1C8")]
	private BoxCollider MBOELLFGFGK;

	[Token(Token = "0x400555B")]
	[FieldOffset(Offset = "0x1CC")]
	private CapsuleCollider PJIALMMOPBG;

	[Token(Token = "0x600407B")]
	[Address(RVA = "0x17EC114", Offset = "0x17EC114", VA = "0x17EC114")]
	public NetworkAIPawn_NPC()
	{
	}

	[Token(Token = "0x600407C")]
	[Address(RVA = "0x17EC1F4", Offset = "0x17EC1F4", VA = "0x17EC1F4")]
	public bool IsInteractive()
	{
		return default(bool);
	}

	[Token(Token = "0x600407D")]
	[Address(RVA = "0x17EC268", Offset = "0x17EC268", VA = "0x17EC268", Slot = "67")]
	public override void CreateInit(Transform GOLANILPAJP, EBNJADFGCFA KEJFOBBEAJO)
	{
	}

	[Token(Token = "0x600407E")]
	[Address(RVA = "0x17EC990", Offset = "0x17EC990", VA = "0x17EC990", Slot = "69")]
	protected override void KMJODBHMEGM()
	{
	}

	[Token(Token = "0x600407F")]
	[Address(RVA = "0x17ED65C", Offset = "0x17ED65C", VA = "0x17ED65C", Slot = "70")]
	protected override void BMINBBBIGIF(Transform GDOGIGDHJJO)
	{
	}

	[Token(Token = "0x6004080")]
	[Address(RVA = "0x17ECFE8", Offset = "0x17ECFE8", VA = "0x17ECFE8")]
	private void ECKKKEFPFHB()
	{
	}

	[Token(Token = "0x6004081")]
	[Address(RVA = "0x17ED85C", Offset = "0x17ED85C", VA = "0x17ED85C")]
	private void KKHHHFKKBCF(UMAData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004082")]
	[Address(RVA = "0x17DBA0C", Offset = "0x17DBA0C", VA = "0x17DBA0C")]
	public void OnPlayerEnterTrigger()
	{
	}

	[Token(Token = "0x6004083")]
	[Address(RVA = "0x17EDD68", Offset = "0x17EDD68", VA = "0x17EDD68")]
	public void StartTalking(uint NLOMOJMMNHK, string DMCBMNKNHPM)
	{
	}

	[Token(Token = "0x6004084")]
	[Address(RVA = "0x17EE040", Offset = "0x17EE040", VA = "0x17EE040", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004085")]
	[Address(RVA = "0x17EE638", Offset = "0x17EE638", VA = "0x17EE638", Slot = "71")]
	public override void UpdateBehavior(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004086")]
	[Address(RVA = "0x17EE6A8", Offset = "0x17EE6A8", VA = "0x17EE6A8", Slot = "72")]
	public override void UpdateKinematics(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004087")]
	[Address(RVA = "0x17ED6B8", Offset = "0x17ED6B8", VA = "0x17ED6B8")]
	public void PlayNPCAnim(ResourceID KMIPBIGPDPI, bool ANDPBKOAIKH = false, float KPCJADGMEJG = 0f)
	{
	}

	[Token(Token = "0x6004088")]
	[Address(RVA = "0x17EE718", Offset = "0x17EE718", VA = "0x17EE718")]
	private void LJNJJDAFGLH(string MBOCHECKLMJ, AnimRef DIENGEMMHFF)
	{
	}

	[Token(Token = "0x6004089")]
	[Address(RVA = "0x17EE9F4", Offset = "0x17EE9F4", VA = "0x17EE9F4", Slot = "58")]
	protected override void OnDead()
	{
	}

	[Token(Token = "0x600408A")]
	[Address(RVA = "0x17EF028", Offset = "0x17EF028", VA = "0x17EF028")]
	public void HideNPCName(bool FMLAEEMJLKI)
	{
	}

	[Token(Token = "0x600408B")]
	[Address(RVA = "0x17EF0CC", Offset = "0x17EF0CC", VA = "0x17EF0CC")]
	public void OnStartInteract()
	{
	}

	[Token(Token = "0x600408C")]
	[Address(RVA = "0x17EF2F0", Offset = "0x17EF2F0", VA = "0x17EF2F0")]
	public void OnEndInteract()
	{
	}

	[Token(Token = "0x600408D")]
	[Address(RVA = "0x17EF370", Offset = "0x17EF370", VA = "0x17EF370")]
	public void _003C_003EiFixBaseProxy_CreateInit(Transform P0, EBNJADFGCFA P1)
	{
	}

	[Token(Token = "0x600408E")]
	[Address(RVA = "0x17EF374", Offset = "0x17EF374", VA = "0x17EF374")]
	public void _003C_003EiFixBaseProxy_KMJODBHMEGM()
	{
	}

	[Token(Token = "0x600408F")]
	[Address(RVA = "0x17EF378", Offset = "0x17EF378", VA = "0x17EF378")]
	public void _003C_003EiFixBaseProxy_BMINBBBIGIF(Transform P0)
	{
	}

	[Token(Token = "0x6004090")]
	[Address(RVA = "0x17EF37C", Offset = "0x17EF37C", VA = "0x17EF37C")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6004091")]
	[Address(RVA = "0x17EF384", Offset = "0x17EF384", VA = "0x17EF384")]
	public void _003C_003EiFixBaseProxy_UpdateBehavior(float P0, float P1)
	{
	}

	[Token(Token = "0x6004092")]
	[Address(RVA = "0x17EF388", Offset = "0x17EF388", VA = "0x17EF388")]
	public void _003C_003EiFixBaseProxy_UpdateKinematics(float P0, float P1)
	{
	}

	[Token(Token = "0x6004093")]
	[Address(RVA = "0x17EF38C", Offset = "0x17EF38C", VA = "0x17EF38C")]
	public void _003C_003EiFixBaseProxy_OnDead()
	{
	}
}
