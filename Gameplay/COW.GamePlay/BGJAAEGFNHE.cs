using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20009A5")]
internal interface BGJAAEGFNHE
{
	[Token(Token = "0x60049E6")]
	void PushPlayerSyncedStateData(object ANBEGGDFLBM, uint LPJONPCPBED);

	[Token(Token = "0x60049E7")]
	void PushPlayerSyncedOptimizedStateData(object ANBEGGDFLBM, uint LPJONPCPBED);

	[Token(Token = "0x60049E8")]
	void PushPlayerSyncedPosition(object HDMDADEMHLL, uint LPJONPCPBED);

	[Token(Token = "0x60049E9")]
	void SyncStartFire(byte GLDLCOBLGNF);

	[Token(Token = "0x60049EA")]
	void SyncStopFire();

	[Token(Token = "0x60049EB")]
	void SyncStartReload(float MLPAAKNGDLA);

	[Token(Token = "0x60049EC")]
	void SyncStopReload(OFICGIIFGMF LHCHNFGKLHD);

	[Token(Token = "0x60049ED")]
	void SyncPickupInventory(LHODJLEHDND LHCHNFGKLHD);

	[Token(Token = "0x60049EE")]
	void SyncDropInventory(KJBONEENCAL LHCHNFGKLHD);

	[Token(Token = "0x60049EF")]
	void SyncRemoveInventoryList(ABJFDIFIILN LHCHNFGKLHD);

	[Token(Token = "0x60049F0")]
	void SyncEquipmentChanged(LJGFNPIMGMA LHCHNFGKLHD);

	[Token(Token = "0x60049F1")]
	void SyncAttachmentChanged(KBDODAHANGB LHCHNFGKLHD);

	[Token(Token = "0x60049F2")]
	void SyncPlayersVisibility(ulong DNHNPDIJHCE);

	[Token(Token = "0x60049F3")]
	void SyncStateWithServer(JIIKBLKJCKM LHCHNFGKLHD);

	[Token(Token = "0x60049F4")]
	void SyncDoAction(FPCOHGNMLBG LHCHNFGKLHD);

	[Token(Token = "0x60049F5")]
	void SyncTryUseInventory(bool ACJKFIKCAOA, uint KFBALILGIIG);

	[Token(Token = "0x60049F6")]
	void SyncLoadoutRuntimeValue(HHNFFMHCPFO LHCHNFGKLHD);

	[Token(Token = "0x60049F7")]
	void SyncPlayEmotionAnimation(NIBOCOJJCCJ LHCHNFGKLHD);

	[Token(Token = "0x60049F8")]
	void SyncKnockDown(NKDBFGLPCCF LHCHNFGKLHD);

	[Token(Token = "0x60049F9")]
	void SyncRevive(Player.GBJAEPHNFMD DMOMICALGHM);

	[Token(Token = "0x60049FA")]
	void OnRequestResureTargetRes(DCBAMPDIHIG KMIPBIGPDPI);

	[Token(Token = "0x60049FB")]
	void OnRequestStopResureTargetRes(CKFGLAAAOFC KMIPBIGPDPI);

	[Token(Token = "0x60049FC")]
	void RequestFoceSyncPosition();

	[Token(Token = "0x60049FD")]
	void SyncStartGrenade();

	[Token(Token = "0x60049FE")]
	void SyncStopGrenade();

	[Token(Token = "0x60049FF")]
	void SyncTriggerGrenade();

	[Token(Token = "0x6004A00")]
	void SyncInventoryInfo(BGKCMKNDAGA KMIPBIGPDPI);

	[Token(Token = "0x6004A01")]
	void SyncAttachmentInfo(List<JPALKHEHFIM> CNLFNIHHCHH);

	[Token(Token = "0x6004A02")]
	void SyncTeleportInfo(JIIKBLKJCKM LHCHNFGKLHD);
}
