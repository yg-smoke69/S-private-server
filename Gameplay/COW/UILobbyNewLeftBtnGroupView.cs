using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003848")]
public class UILobbyNewLeftBtnGroupView : UIBaseView
{
	[Token(Token = "0x4016FE6")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition TweenPosPanelLeft;

	[Token(Token = "0x4016FE7")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid BtnGroupGrid;

	[Token(Token = "0x4016FE8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Store;

	[Token(Token = "0x4016FE9")]
	[FieldOffset(Offset = "0x20")]
	public UISprite StoreIcon;

	[Token(Token = "0x4016FEA")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnStoreSmall;

	[Token(Token = "0x4016FEB")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BtnStoreBig;

	[Token(Token = "0x4016FEC")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BgBtnStore;

	[Token(Token = "0x4016FED")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnStore;

	[Token(Token = "0x4016FEE")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SpriteBtnStore;

	[Token(Token = "0x4016FEF")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget ShopGuide;

	[Token(Token = "0x4016FF0")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject BtnStoreLabel;

	[Token(Token = "0x4016FF1")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Gacha;

	[Token(Token = "0x4016FF2")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnGachaSmall;

	[Token(Token = "0x4016FF3")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BtnGachaBig;

	[Token(Token = "0x4016FF4")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton UIButtonBtnGacha;

	[Token(Token = "0x4016FF5")]
	[FieldOffset(Offset = "0x50")]
	public UISprite UISpriteBtnGacha;

	[Token(Token = "0x4016FF6")]
	[FieldOffset(Offset = "0x54")]
	public GameObject GachaNewTips;

	[Token(Token = "0x4016FF7")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget GachaGuide;

	[Token(Token = "0x4016FF8")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BtnGachaLabel;

	[Token(Token = "0x4016FF9")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Avatar;

	[Token(Token = "0x4016FFA")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BtnAvatarSmall;

	[Token(Token = "0x4016FFB")]
	[FieldOffset(Offset = "0x68")]
	public GameObject BtnAvatarBig;

	[Token(Token = "0x4016FFC")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject BtnAvatarLabel;

	[Token(Token = "0x4016FFD")]
	[FieldOffset(Offset = "0x70")]
	public UIButton UIButtonBtnAvatar;

	[Token(Token = "0x4016FFE")]
	[FieldOffset(Offset = "0x74")]
	public UISprite UISpriteBtnAvatar;

	[Token(Token = "0x4016FFF")]
	[FieldOffset(Offset = "0x78")]
	public GameObject AvatarNewGO;

	[Token(Token = "0x4017000")]
	[FieldOffset(Offset = "0x7C")]
	public UIWidget AvatarWidget;

	[Token(Token = "0x4017001")]
	[FieldOffset(Offset = "0x80")]
	public Transform AwakenGuideGo;

	[Token(Token = "0x4017002")]
	[FieldOffset(Offset = "0x84")]
	public UIWidget RoleGuide;

	[Token(Token = "0x4017003")]
	[FieldOffset(Offset = "0x88")]
	public GameObject NewValut;

	[Token(Token = "0x4017004")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton BtnNewVaultSmall;

	[Token(Token = "0x4017005")]
	[FieldOffset(Offset = "0x90")]
	public GameObject BtnNewVaultBig;

	[Token(Token = "0x4017006")]
	[FieldOffset(Offset = "0x94")]
	public GameObject BtnNewVaultLabel;

	[Token(Token = "0x4017007")]
	[FieldOffset(Offset = "0x98")]
	public UIButton BtnNewVault;

	[Token(Token = "0x4017008")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite NewVaultGuide;

	[Token(Token = "0x4017009")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject NewVaultTips;

	[Token(Token = "0x401700A")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject Pet;

	[Token(Token = "0x401700B")]
	[FieldOffset(Offset = "0xA8")]
	public UIButton BtnPetSmall;

	[Token(Token = "0x401700C")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject BtnPetBig;

	[Token(Token = "0x401700D")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject BtnPetLabel;

	[Token(Token = "0x401700E")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton UIButtonBtnPet;

	[Token(Token = "0x401700F")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite UISpriteBtnPet;

	[Token(Token = "0x4017010")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject PetNewGO;

	[Token(Token = "0x4017011")]
	[FieldOffset(Offset = "0xC0")]
	public UIWidget PetGuide;

	[Token(Token = "0x4017012")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject LabEntranceGroup;

	[Token(Token = "0x4017013")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton LabEntranceBtnSmall;

	[Token(Token = "0x4017014")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject LabEntranceDetails;

	[Token(Token = "0x4017015")]
	[FieldOffset(Offset = "0xD0")]
	public UIButton LabEntranceBtnLarge;

	[Token(Token = "0x4017016")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject LabEntranceNewTipsIcon;

	[Token(Token = "0x4017017")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject WeaponSkinMain;

	[Token(Token = "0x4017018")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton BtnWeaponSkinSmall;

	[Token(Token = "0x4017019")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject BtnWeaponSkinBig;

	[Token(Token = "0x401701A")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject BtnWeaponSkinLabel;

	[Token(Token = "0x401701B")]
	[FieldOffset(Offset = "0xE8")]
	public UIButton BtnWeaponSkin;

	[Token(Token = "0x401701C")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject WSUUpgradeTag;

	[Token(Token = "0x401701D")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject WSUSysNewTag;

	[Token(Token = "0x401701E")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject LabEntranceTipsIcon;

	[Token(Token = "0x401701F")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject AvatarTipsOnOff;

	[Token(Token = "0x4017020")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject LadderMatch;

	[Token(Token = "0x4017021")]
	[FieldOffset(Offset = "0x100")]
	public UIButton BtnLadderMatchSmall;

	[Token(Token = "0x4017022")]
	[FieldOffset(Offset = "0x104")]
	public UIButton BtnLadderMatch;

	[Token(Token = "0x4017023")]
	[FieldOffset(Offset = "0x108")]
	public GameObject Task;

	[Token(Token = "0x4017024")]
	[FieldOffset(Offset = "0x10C")]
	public UIButton BtnTaskSmall;

	[Token(Token = "0x4017025")]
	[FieldOffset(Offset = "0x110")]
	public UIButton BtnTask;

	[Token(Token = "0x4017026")]
	[FieldOffset(Offset = "0x114")]
	public GameObject BtnTaskBig;

	[Token(Token = "0x4017027")]
	[FieldOffset(Offset = "0x118")]
	public GameObject BtnLadderMatchBig;

	[Token(Token = "0x6016C83")]
	[Address(RVA = "0x1F9F024", Offset = "0x1F9F024", VA = "0x1F9F024")]
	public UILobbyNewLeftBtnGroupView()
	{
	}

	[Token(Token = "0x6016C84")]
	[Address(RVA = "0x1F9F02C", Offset = "0x1F9F02C", VA = "0x1F9F02C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C85")]
	[Address(RVA = "0x1FA0880", Offset = "0x1FA0880", VA = "0x1FA0880")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
