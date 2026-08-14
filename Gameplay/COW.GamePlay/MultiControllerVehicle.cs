using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000CFB")]
internal class MultiControllerVehicle : Vehicle
{
	[Serializable]
	[Token(Token = "0x2000CFC")]
	public class ControllerPair
	{
		[Token(Token = "0x4006918")]
		[FieldOffset(Offset = "0x8")]
		public GECEMDDEIMI Shape;

		[Token(Token = "0x4006919")]
		[FieldOffset(Offset = "0xC")]
		public GameObject ControllerObject;

		[Token(Token = "0x400691A")]
		[FieldOffset(Offset = "0x10")]
		public CarAudioComponent VehicleAudio;

		[Token(Token = "0x400691B")]
		[FieldOffset(Offset = "0x14")]
		internal VehicleControllerInterface Controller;

		[Token(Token = "0x400691C")]
		[FieldOffset(Offset = "0x18")]
		public int ConfigIndex;

		[Token(Token = "0x60062B3")]
		[Address(RVA = "0x1BF77F8", Offset = "0x1BF77F8", VA = "0x1BF77F8")]
		public ControllerPair()
		{
		}
	}

	[Token(Token = "0x2000CFD")]
	private sealed class KGJBPNIJMCK
	{
		[Token(Token = "0x400691D")]
		[FieldOffset(Offset = "0x8")]
		internal float PHEJDNJONIL;

		[Token(Token = "0x60062B4")]
		[Address(RVA = "0x1BF2D94", Offset = "0x1BF2D94", VA = "0x1BF2D94")]
		public KGJBPNIJMCK()
		{
		}

		[Token(Token = "0x60062B5")]
		[Address(RVA = "0x1BF7800", Offset = "0x1BF7800", VA = "0x1BF7800")]
		internal void CHOPCLCOBKC(VehicleControllerInterface GBDCICHCNFC)
		{
		}
	}

	[Token(Token = "0x400690F")]
	[FieldOffset(Offset = "0x270")]
	public ControllerPair[] Controllers;

	[Token(Token = "0x4006910")]
	[FieldOffset(Offset = "0x274")]
	protected Dictionary<int, ControllerPair> LLPOABJOBGA;

	[Token(Token = "0x4006911")]
	[FieldOffset(Offset = "0x278")]
	protected ControllerPair GEDBOFFGPIN;

	[Token(Token = "0x4006912")]
	[FieldOffset(Offset = "0x27C")]
	protected GECEMDDEIMI NEIKJKOINKP;

	[Token(Token = "0x4006913")]
	[FieldOffset(Offset = "0x27D")]
	protected GECEMDDEIMI EGOBBHJJAFL;

	[Token(Token = "0x4006914")]
	[FieldOffset(Offset = "0x280")]
	protected GameObject KIKLGCHBKNF;

	[Token(Token = "0x4006915")]
	[FieldOffset(Offset = "0x284")]
	protected ParachutejumpCarController IJGMEBLCNPJ;

	[Token(Token = "0x4006916")]
	[FieldOffset(Offset = "0x288")]
	private ParachutejumpCarController.GFGIBNBHKMA MHPNNLLFDKO;

	[Token(Token = "0x4006917")]
	[FieldOffset(Offset = "0x0")]
	private static Action<VehicleControllerInterface> HMDOHFBHDOB;

	[Token(Token = "0x17000834")]
	public override CarAudioComponent LNLMNDKBELB
	{
		[Token(Token = "0x600626A")]
		[Address(RVA = "0x1BF2104", Offset = "0x1BF2104", VA = "0x1BF2104", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006263")]
	[Address(RVA = "0x1BF0E3C", Offset = "0x1BF0E3C", VA = "0x1BF0E3C")]
	public MultiControllerVehicle()
	{
	}

	[Token(Token = "0x6006264")]
	[Address(RVA = "0x1BF0EC0", Offset = "0x1BF0EC0", VA = "0x1BF0EC0", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6006265")]
	[Address(RVA = "0x1BF0F2C", Offset = "0x1BF0F2C", VA = "0x1BF0F2C")]
	protected void NLAHNNAOBFM()
	{
	}

	[Token(Token = "0x6006266")]
	[Address(RVA = "0x1BF1A58", Offset = "0x1BF1A58", VA = "0x1BF1A58", Slot = "84")]
	protected override void JKCBPIGHJJA()
	{
	}

	[Token(Token = "0x6006267")]
	[Address(RVA = "0x1BF1B98", Offset = "0x1BF1B98", VA = "0x1BF1B98", Slot = "82")]
	protected override void NPNBDCPFJDM(float NKPFEBMAAKP)
	{
	}

	[Token(Token = "0x6006268")]
	[Address(RVA = "0x1BF1EC0", Offset = "0x1BF1EC0", VA = "0x1BF1EC0", Slot = "87")]
	public override void SyncChangeShape(byte KENDCFNPDCE)
	{
	}

	[Token(Token = "0x6006269")]
	[Address(RVA = "0x1BF1F78", Offset = "0x1BF1F78", VA = "0x1BF1F78", Slot = "88")]
	public override void SendChangeShape()
	{
	}

	[Token(Token = "0x600626B")]
	[Address(RVA = "0x1BF2174", Offset = "0x1BF2174", VA = "0x1BF2174")]
	public void OnStopJump()
	{
	}

	[Token(Token = "0x600626C")]
	[Address(RVA = "0x1BF229C", Offset = "0x1BF229C", VA = "0x1BF229C", Slot = "81")]
	protected override void MJCHMIADGLP(Dictionary<string, VehicleControllerInfo> NBHOKNOBOEE)
	{
	}

	[Token(Token = "0x600626D")]
	[Address(RVA = "0x1BF2640", Offset = "0x1BF2640", VA = "0x1BF2640", Slot = "101")]
	protected override void AJMKGJMHMOL([Optional] VehicleSkinInfoBase MEIAMJMMECB)
	{
	}

	[Token(Token = "0x600626E")]
	[Address(RVA = "0x1BF2A34", Offset = "0x1BF2A34", VA = "0x1BF2A34", Slot = "102")]
	public override void ChangeProperty(string BFBMDJAICGD, float KKFLFMACNKA)
	{
	}

	[Token(Token = "0x600626F")]
	[Address(RVA = "0x1BF2C3C", Offset = "0x1BF2C3C", VA = "0x1BF2C3C", Slot = "79")]
	public override void LockSpeed()
	{
	}

	[Token(Token = "0x6006270")]
	[Address(RVA = "0x1BF2EC0", Offset = "0x1BF2EC0", VA = "0x1BF2EC0", Slot = "80")]
	public override void UnLockSpeed()
	{
	}

	[Token(Token = "0x6006271")]
	[Address(RVA = "0x1BF2D9C", Offset = "0x1BF2D9C", VA = "0x1BF2D9C")]
	protected void MAJNBHDABNA(Action<VehicleControllerInterface> BLHEBBCODLC)
	{
	}

	[Token(Token = "0x6006272")]
	[Address(RVA = "0x1BF21F0", Offset = "0x1BF21F0", VA = "0x1BF21F0")]
	public void ChangeShape(GECEMDDEIMI PHEJDNJONIL)
	{
	}

	[Token(Token = "0x6006273")]
	[Address(RVA = "0x1BF2FFC", Offset = "0x1BF2FFC", VA = "0x1BF2FFC")]
	protected void LGNFLDIMPLJ(GECEMDDEIMI PHEJDNJONIL, bool CMLDPLPCCID)
	{
	}

	[Token(Token = "0x6006274")]
	[Address(RVA = "0x1BF3734", Offset = "0x1BF3734", VA = "0x1BF3734", Slot = "77")]
	protected override void FNGMCAAKBDG(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6006275")]
	[Address(RVA = "0x1BF31AC", Offset = "0x1BF31AC", VA = "0x1BF31AC")]
	private void MPAANECMKBE(CarAudioComponent GMJOBAMEMDP, CarAudioComponent FDEJKGIAKNM)
	{
	}

	[Token(Token = "0x6006276")]
	[Address(RVA = "0x1BF337C", Offset = "0x1BF337C", VA = "0x1BF337C")]
	private void LGNFLDIMPLJ(VehicleControllerInterface GBDCICHCNFC, bool CMLDPLPCCID)
	{
	}

	[Token(Token = "0x6006277")]
	[Address(RVA = "0x1BF3934", Offset = "0x1BF3934", VA = "0x1BF3934")]
	protected void MFHFBLOPFOC(VehicleControllerInterface OOMJGMJKNCK, VehicleControllerInterface HKNPJFEBHDH)
	{
	}

	[Token(Token = "0x6006278")]
	[Address(RVA = "0x1BF3B00", Offset = "0x1BF3B00", VA = "0x1BF3B00", Slot = "103")]
	protected virtual void JCHNOIJMGNB(GECEMDDEIMI PHEJDNJONIL)
	{
	}

	[Token(Token = "0x6006279")]
	[Address(RVA = "0x1BF1AD8", Offset = "0x1BF1AD8", VA = "0x1BF1AD8")]
	protected void HCPNOOLLDGO(bool ILJFDMIHKFB)
	{
	}

	[Token(Token = "0x600627A")]
	[Address(RVA = "0x1BF3B60", Offset = "0x1BF3B60", VA = "0x1BF3B60", Slot = "104")]
	protected virtual void HBBNGNGMPMD(GECEMDDEIMI FGNPHJJLELJ, GECEMDDEIMI MLGKHMFMJHP, bool ILJFDMIHKFB)
	{
	}

	[Token(Token = "0x600627B")]
	[Address(RVA = "0x1BF17C4", Offset = "0x1BF17C4", VA = "0x1BF17C4")]
	public void InitParachutejumpController()
	{
	}

	[Token(Token = "0x600627C")]
	[Address(RVA = "0x1BF3BD4", Offset = "0x1BF3BD4", VA = "0x1BF3BD4")]
	public void onParachuteStateTick(ParachutejumpCarController.GFGIBNBHKMA NKNAAOKGNHE, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600627D")]
	[Address(RVA = "0x1BF3FFC", Offset = "0x1BF3FFC", VA = "0x1BF3FFC", Slot = "91")]
	public override void InitStateWithPlayer(bool LAEJNDBBKGK, byte CMBHDPFEGFJ, Player BONOAOGGOGH, bool LGBFFOLBHHC = false, int LBKILHPDOKD = -1)
	{
	}

	[Token(Token = "0x600627E")]
	[Address(RVA = "0x1BF4214", Offset = "0x1BF4214", VA = "0x1BF4214")]
	private void ILFEMIEMOOL()
	{
	}

	[Token(Token = "0x600627F")]
	[Address(RVA = "0x1BF4290", Offset = "0x1BF4290", VA = "0x1BF4290")]
	private void LBCDAKJANNM(ParachutejumpCarController.GFGIBNBHKMA KOHBEGFKAHN)
	{
	}

	[Token(Token = "0x6006280")]
	[Address(RVA = "0x1BF3C9C", Offset = "0x1BF3C9C", VA = "0x1BF3C9C")]
	private void KPAMCPOFLBP()
	{
	}

	[Token(Token = "0x6006281")]
	[Address(RVA = "0x1BF3F78", Offset = "0x1BF3F78", VA = "0x1BF3F78")]
	private void KDHDOPHDKFA(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6006282")]
	[Address(RVA = "0x1BF43EC", Offset = "0x1BF43EC", VA = "0x1BF43EC", Slot = "92")]
	public override void StartOnBoard()
	{
	}

	[Token(Token = "0x6006283")]
	[Address(RVA = "0x1BF4578", Offset = "0x1BF4578", VA = "0x1BF4578")]
	private void GIOLPGHMMDJ()
	{
	}

	[Token(Token = "0x6006284")]
	[Address(RVA = "0x1BF4688", Offset = "0x1BF4688", VA = "0x1BF4688")]
	private void HOJAJHOEBAG()
	{
	}

	[Token(Token = "0x6006285")]
	[Address(RVA = "0x1BF4844", Offset = "0x1BF4844", VA = "0x1BF4844")]
	private void NGMLLPAFBAM()
	{
	}

	[Token(Token = "0x6006286")]
	[Address(RVA = "0x1BF5608", Offset = "0x1BF5608", VA = "0x1BF5608", Slot = "93")]
	public override void StartSkyDiving()
	{
	}

	[Token(Token = "0x6006287")]
	[Address(RVA = "0x1BF5794", Offset = "0x1BF5794", VA = "0x1BF5794")]
	private void LMCKOFKKHHF()
	{
	}

	[Token(Token = "0x6006288")]
	[Address(RVA = "0x1BF591C", Offset = "0x1BF591C", VA = "0x1BF591C")]
	private void JCKMDEMINBA()
	{
	}

	[Token(Token = "0x6006289")]
	[Address(RVA = "0x1BF597C", Offset = "0x1BF597C", VA = "0x1BF597C")]
	private void HKAHMNACOOI()
	{
	}

	[Token(Token = "0x600628A")]
	[Address(RVA = "0x1BF67CC", Offset = "0x1BF67CC", VA = "0x1BF67CC", Slot = "94")]
	public override void StartParachute()
	{
	}

	[Token(Token = "0x600628B")]
	[Address(RVA = "0x1BF684C", Offset = "0x1BF684C", VA = "0x1BF684C")]
	private void IAGBDCJEKFB()
	{
	}

	[Token(Token = "0x600628C")]
	[Address(RVA = "0x1BF69D4", Offset = "0x1BF69D4", VA = "0x1BF69D4")]
	private void BIONCIBLPON()
	{
	}

	[Token(Token = "0x600628D")]
	[Address(RVA = "0x1BF6A34", Offset = "0x1BF6A34", VA = "0x1BF6A34")]
	private void IALNNBOKJHM()
	{
	}

	[Token(Token = "0x600628E")]
	[Address(RVA = "0x1BF436C", Offset = "0x1BF436C", VA = "0x1BF436C")]
	private void JMDFBONCCDA()
	{
	}

	[Token(Token = "0x600628F")]
	[Address(RVA = "0x1BF6D5C", Offset = "0x1BF6D5C", VA = "0x1BF6D5C")]
	private void BKABIMHMFDD()
	{
	}

	[Token(Token = "0x6006290")]
	[Address(RVA = "0x1BF6C98", Offset = "0x1BF6C98", VA = "0x1BF6C98")]
	private void GPODONMLNEL()
	{
	}

	[Token(Token = "0x6006291")]
	[Address(RVA = "0x1BF6DBC", Offset = "0x1BF6DBC", VA = "0x1BF6DBC")]
	private void EHKDIKBPNBH()
	{
	}

	[Token(Token = "0x6006292")]
	[Address(RVA = "0x1BF70E4", Offset = "0x1BF70E4", VA = "0x1BF70E4", Slot = "85")]
	public override void SetVisibility(uint EBOJJLIHHCM, bool GKCPPPINMPB)
	{
	}

	[Token(Token = "0x6006293")]
	[Address(RVA = "0x1BF6354", Offset = "0x1BF6354", VA = "0x1BF6354")]
	private void HMJEPLCKMMF(bool EDLIFKGBCMD)
	{
	}

	[Token(Token = "0x6006294")]
	[Address(RVA = "0x1BF46E8", Offset = "0x1BF46E8", VA = "0x1BF46E8")]
	protected void KHAPMNIOFDP(ParachutejumpCarController.GFGIBNBHKMA GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6006295")]
	[Address(RVA = "0x1BF71C0", Offset = "0x1BF71C0", VA = "0x1BF71C0", Slot = "89")]
	public override void SyncParachuteState(byte GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6006296")]
	[Address(RVA = "0x1BF7240", Offset = "0x1BF7240", VA = "0x1BF7240", Slot = "95")]
	public override bool IsInParachuteJumpState()
	{
		return default(bool);
	}

	[Token(Token = "0x6006297")]
	[Address(RVA = "0x1BF72A4", Offset = "0x1BF72A4", VA = "0x1BF72A4", Slot = "96")]
	public override void OnBevActionCome()
	{
	}

	[Token(Token = "0x6006298")]
	[Address(RVA = "0x1BF4D04", Offset = "0x1BF4D04", VA = "0x1BF4D04")]
	private void AENKHJNKOHJ(ParachutejumpCarController.GFGIBNBHKMA HKAABMDNNAG)
	{
	}

	[Token(Token = "0x6006299")]
	[Address(RVA = "0x1BF732C", Offset = "0x1BF732C", VA = "0x1BF732C", Slot = "97")]
	public override bool IsOnBoard()
	{
		return default(bool);
	}

	[Token(Token = "0x600629A")]
	[Address(RVA = "0x1BF65FC", Offset = "0x1BF65FC", VA = "0x1BF65FC")]
	private void FMINPHLEIAH(bool ELCCGHHAPCA)
	{
	}

	[Token(Token = "0x600629B")]
	[Address(RVA = "0x1BF7390", Offset = "0x1BF7390", VA = "0x1BF7390", Slot = "98")]
	public override void StopParachutEffect()
	{
	}

	[Token(Token = "0x600629C")]
	[Address(RVA = "0x1BF7650", Offset = "0x1BF7650", VA = "0x1BF7650")]
	private static void MMPOPIKNEIP(VehicleControllerInterface GBDCICHCNFC)
	{
	}

	[Token(Token = "0x600629D")]
	[Address(RVA = "0x1BF7724", Offset = "0x1BF7724", VA = "0x1BF7724")]
	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x600629E")]
	[Address(RVA = "0x1BF772C", Offset = "0x1BF772C", VA = "0x1BF772C")]
	public void _003C_003EiFixBaseProxy_JKCBPIGHJJA()
	{
	}

	[Token(Token = "0x600629F")]
	[Address(RVA = "0x1BF7734", Offset = "0x1BF7734", VA = "0x1BF7734")]
	public void _003C_003EiFixBaseProxy_NPNBDCPFJDM(float P0)
	{
	}

	[Token(Token = "0x60062A0")]
	[Address(RVA = "0x1BF773C", Offset = "0x1BF773C", VA = "0x1BF773C")]
	public void _003C_003EiFixBaseProxy_SyncChangeShape(byte P0)
	{
	}

	[Token(Token = "0x60062A1")]
	[Address(RVA = "0x1BF7744", Offset = "0x1BF7744", VA = "0x1BF7744")]
	public void _003C_003EiFixBaseProxy_SendChangeShape()
	{
	}

	[Token(Token = "0x60062A2")]
	[Address(RVA = "0x1BF774C", Offset = "0x1BF774C", VA = "0x1BF774C")]
	public CarAudioComponent _003C_003EiFixBaseProxy_get_VehicleAudio()
	{
		return null;
	}

	[Token(Token = "0x60062A3")]
	[Address(RVA = "0x1BF7754", Offset = "0x1BF7754", VA = "0x1BF7754")]
	public void _003C_003EiFixBaseProxy_MJCHMIADGLP(Dictionary<string, VehicleControllerInfo> P0)
	{
	}

	[Token(Token = "0x60062A4")]
	[Address(RVA = "0x1BF775C", Offset = "0x1BF775C", VA = "0x1BF775C")]
	public void _003C_003EiFixBaseProxy_AJMKGJMHMOL(VehicleSkinInfoBase P0)
	{
	}

	[Token(Token = "0x60062A5")]
	[Address(RVA = "0x1BF7764", Offset = "0x1BF7764", VA = "0x1BF7764")]
	public void _003C_003EiFixBaseProxy_ChangeProperty(string P0, float P1)
	{
	}

	[Token(Token = "0x60062A6")]
	[Address(RVA = "0x1BF776C", Offset = "0x1BF776C", VA = "0x1BF776C")]
	public void _003C_003EiFixBaseProxy_LockSpeed()
	{
	}

	[Token(Token = "0x60062A7")]
	[Address(RVA = "0x1BF7774", Offset = "0x1BF7774", VA = "0x1BF7774")]
	public void _003C_003EiFixBaseProxy_UnLockSpeed()
	{
	}

	[Token(Token = "0x60062A8")]
	[Address(RVA = "0x1BF777C", Offset = "0x1BF777C", VA = "0x1BF777C")]
	public void _003C_003EiFixBaseProxy_FNGMCAAKBDG(bool P0)
	{
	}

	[Token(Token = "0x60062A9")]
	[Address(RVA = "0x1BF7784", Offset = "0x1BF7784", VA = "0x1BF7784")]
	public void _003C_003EiFixBaseProxy_InitStateWithPlayer(bool P0, byte P1, Player P2, bool P3, int P4)
	{
	}

	[Token(Token = "0x60062AA")]
	[Address(RVA = "0x1BF77B0", Offset = "0x1BF77B0", VA = "0x1BF77B0")]
	public void _003C_003EiFixBaseProxy_StartOnBoard()
	{
	}

	[Token(Token = "0x60062AB")]
	[Address(RVA = "0x1BF77B8", Offset = "0x1BF77B8", VA = "0x1BF77B8")]
	public void _003C_003EiFixBaseProxy_StartSkyDiving()
	{
	}

	[Token(Token = "0x60062AC")]
	[Address(RVA = "0x1BF77C0", Offset = "0x1BF77C0", VA = "0x1BF77C0")]
	public void _003C_003EiFixBaseProxy_StartParachute()
	{
	}

	[Token(Token = "0x60062AD")]
	[Address(RVA = "0x1BF77C8", Offset = "0x1BF77C8", VA = "0x1BF77C8")]
	public void _003C_003EiFixBaseProxy_SetVisibility(uint P0, bool P1)
	{
	}

	[Token(Token = "0x60062AE")]
	[Address(RVA = "0x1BF77D0", Offset = "0x1BF77D0", VA = "0x1BF77D0")]
	public void _003C_003EiFixBaseProxy_SyncParachuteState(byte P0)
	{
	}

	[Token(Token = "0x60062AF")]
	[Address(RVA = "0x1BF77D8", Offset = "0x1BF77D8", VA = "0x1BF77D8")]
	public bool _003C_003EiFixBaseProxy_IsInParachuteJumpState()
	{
		return default(bool);
	}

	[Token(Token = "0x60062B0")]
	[Address(RVA = "0x1BF77E0", Offset = "0x1BF77E0", VA = "0x1BF77E0")]
	public void _003C_003EiFixBaseProxy_OnBevActionCome()
	{
	}

	[Token(Token = "0x60062B1")]
	[Address(RVA = "0x1BF77E8", Offset = "0x1BF77E8", VA = "0x1BF77E8")]
	public bool _003C_003EiFixBaseProxy_IsOnBoard()
	{
		return default(bool);
	}

	[Token(Token = "0x60062B2")]
	[Address(RVA = "0x1BF77F0", Offset = "0x1BF77F0", VA = "0x1BF77F0")]
	public void _003C_003EiFixBaseProxy_StopParachutEffect()
	{
	}
}
