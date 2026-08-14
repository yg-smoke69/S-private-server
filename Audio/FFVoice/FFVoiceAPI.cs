using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FFVoice;

[Token(Token = "0x2003B3D")]
public class FFVoiceAPI
{
	[Token(Token = "0x2003B3E")]
	private enum CallbackType
	{
		[Token(Token = "0x40193DA")]
		CALLBACK_TYPE_EVENT,
		[Token(Token = "0x40193DB")]
		CALLBACK_TYPE_REST_API_RESPONSE,
		[Token(Token = "0x40193DC")]
		CALLBACK_TYPE_MEMBER_CHANGE,
		[Token(Token = "0x40193DD")]
		CALLBACK_TYPE_BROADCAST
	}

	[Token(Token = "0x2003B3F")]
	private struct UnityPcmCallbackData
	{
		[Token(Token = "0x40193DE")]
		[FieldOffset(Offset = "0x0")]
		public int channelNum;

		[Token(Token = "0x40193DF")]
		[FieldOffset(Offset = "0x4")]
		public int samplingRateHz;

		[Token(Token = "0x40193E0")]
		[FieldOffset(Offset = "0x8")]
		public int bytesPerSample;

		[Token(Token = "0x40193E1")]
		[FieldOffset(Offset = "0xC")]
		public IntPtr data;

		[Token(Token = "0x40193E2")]
		[FieldOffset(Offset = "0x10")]
		public int dataSizeInByte;

		[Token(Token = "0x40193E3")]
		[FieldOffset(Offset = "0x14")]
		public int flag;
	}

	[Token(Token = "0x2003B40")]
	public class FFVoicePcmCallbackData
	{
		[Token(Token = "0x40193E4")]
		[FieldOffset(Offset = "0x8")]
		public int channelNum;

		[Token(Token = "0x40193E5")]
		[FieldOffset(Offset = "0xC")]
		public int samplingRateHz;

		[Token(Token = "0x40193E6")]
		[FieldOffset(Offset = "0x10")]
		public int bytesPerSample;

		[Token(Token = "0x40193E7")]
		[FieldOffset(Offset = "0x14")]
		public byte[] data;

		[Token(Token = "0x40193E8")]
		[FieldOffset(Offset = "0x18")]
		public FFVoicePcmCallBackFlag flag;

		[Token(Token = "0x60178B4")]
		[Address(RVA = "0x3214554", Offset = "0x3214554", VA = "0x3214554")]
		public FFVoicePcmCallbackData(int channelNum, int samplingRateHz, int bytesPerSample, IntPtr data, int dataSizeInByte, FFVoicePcmCallBackFlag flag)
		{
		}

		[Token(Token = "0x60178B5")]
		[Address(RVA = "0x3217FCC", Offset = "0x3217FCC", VA = "0x3217FCC")]
		public FFVoicePcmCallbackData(int channelNum, int samplingRateHz, int bytesPerSample, byte[] data, FFVoicePcmCallBackFlag flag)
		{
		}
	}

	[Token(Token = "0x2003B41")]
	private delegate void UnityPcmCallbackDelegate(IntPtr unityPcmCallbackData);

	[Token(Token = "0x2003B42")]
	private class FFVoiceCallbackObject : MonoBehaviour
	{
		[Token(Token = "0x60178BA")]
		[Address(RVA = "0x3218374", Offset = "0x3218374", VA = "0x3218374")]
		public FFVoiceCallbackObject()
		{
		}

		[Token(Token = "0x60178BB")]
		[Address(RVA = "0x321837C", Offset = "0x321837C", VA = "0x321837C")]
		private void Start()
		{
		}

		[Token(Token = "0x60178BC")]
		[Address(RVA = "0x32183FC", Offset = "0x32183FC", VA = "0x32183FC")]
		private void FFVoiceCallback()
		{
		}
	}

	[Token(Token = "0x2003B43")]
	private class AndroidPluginCallback : AndroidJavaProxy
	{
		[Token(Token = "0x60178BD")]
		[Address(RVA = "0x3217D84", Offset = "0x3217D84", VA = "0x3217D84")]
		public AndroidPluginCallback()
		{
		}

		[Token(Token = "0x60178BE")]
		[Address(RVA = "0x3217E18", Offset = "0x3217E18", VA = "0x3217E18")]
		public void onPcmDataRemote(int channelNum, int samplingRateHz, int bytesPerSample, AndroidJavaObject javaByteData)
		{
		}

		[Token(Token = "0x60178BF")]
		[Address(RVA = "0x321800C", Offset = "0x321800C", VA = "0x321800C")]
		public void onPcmDataRecord(int channelNum, int samplingRateHz, int bytesPerSample, AndroidJavaObject javaByteData)
		{
		}

		[Token(Token = "0x60178C0")]
		[Address(RVA = "0x32181C0", Offset = "0x32181C0", VA = "0x32181C0")]
		public void onPcmDataMix(int channelNum, int samplingRateHz, int bytesPerSample, AndroidJavaObject javaByteData)
		{
		}
	}

	[Token(Token = "0x40193CF")]
	[FieldOffset(Offset = "0x0")]
	private static FFVoiceAPI mInstance;

	[Token(Token = "0x40193D0")]
	[FieldOffset(Offset = "0x8")]
	private string mCallbackObjName;

	[Token(Token = "0x40193D1")]
	[FieldOffset(Offset = "0x4")]
	private static Action<FFVoicePcmCallbackData> mPcmCallback;

	[Token(Token = "0x40193D2")]
	[FieldOffset(Offset = "0xC")]
	private bool mAndroidInited;

	[Token(Token = "0x40193D3")]
	[FieldOffset(Offset = "0xD")]
	private bool mAndroidInitOK;

	[Token(Token = "0x40193D4")]
	[FieldOffset(Offset = "0x10")]
	private AndroidJavaClass instance_FFVoice_java;

	[Token(Token = "0x40193D5")]
	[FieldOffset(Offset = "0x14")]
	private string mAndroidLibPath;

	[Token(Token = "0x40193D6")]
	[FieldOffset(Offset = "0x18")]
	private bool _withInternalPermissionRequest;

	[Token(Token = "0x40193D7")]
	[FieldOffset(Offset = "0x8")]
	private static UnityPcmCallbackDelegate _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x40193D8")]
	[FieldOffset(Offset = "0xC")]
	private static UnityPcmCallbackDelegate _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x6017815")]
	[Address(RVA = "0x320E4C8", Offset = "0x320E4C8", VA = "0x320E4C8")]
	private FFVoiceAPI()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6017816")]
	[Address(RVA = "0x320E558", Offset = "0x320E558", VA = "0x320E558")]
	private static extern int FFVoice_init(string strAPPKey, string strAPPSecret, int serverRegionId, string strExtServerRegionName);

	[PreserveSig]
	[Token(Token = "0x6017817")]
	[Address(RVA = "0x320E6C0", Offset = "0x320E6C0", VA = "0x320E6C0")]
	private static extern int FFVoice_setConfig(string sdkValidDomain, string QoSReportDomain, string APIDomain, string backupSDKValidIP);

	[PreserveSig]
	[Token(Token = "0x6017818")]
	[Address(RVA = "0x320E840", Offset = "0x320E840", VA = "0x320E840")]
	private static extern int FFVoice_unInit();

	[PreserveSig]
	[Token(Token = "0x6017819")]
	[Address(RVA = "0x320E938", Offset = "0x320E938", VA = "0x320E938")]
	private static extern IntPtr FFVoice_getCbMessage();

	[PreserveSig]
	[Token(Token = "0x601781A")]
	[Address(RVA = "0x320EA38", Offset = "0x320EA38", VA = "0x320EA38")]
	private static extern void FFVoice_freeCbMessage(IntPtr pMsg);

	[PreserveSig]
	[Token(Token = "0x601781B")]
	[Address(RVA = "0x320EB48", Offset = "0x320EB48", VA = "0x320EB48")]
	private static extern int FFVoice_setOutputToSpeaker(bool bOutputToSpeaker);

	[PreserveSig]
	[Token(Token = "0x601781C")]
	[Address(RVA = "0x320EC28", Offset = "0x320EC28", VA = "0x320EC28")]
	private static extern void FFVoice_setSpeakerMute(bool bOn);

	[PreserveSig]
	[Token(Token = "0x601781D")]
	[Address(RVA = "0x320ED40", Offset = "0x320ED40", VA = "0x320ED40")]
	private static extern bool FFVoice_getSpeakerMute();

	[PreserveSig]
	[Token(Token = "0x601781E")]
	[Address(RVA = "0x320EE50", Offset = "0x320EE50", VA = "0x320EE50")]
	private static extern bool FFVoice_getMicrophoneMute();

	[PreserveSig]
	[Token(Token = "0x601781F")]
	[Address(RVA = "0x320EF60", Offset = "0x320EF60", VA = "0x320EF60")]
	private static extern void FFVoice_setMicrophoneMute(bool mute);

	[PreserveSig]
	[Token(Token = "0x6017820")]
	[Address(RVA = "0x320F078", Offset = "0x320F078", VA = "0x320F078")]
	private static extern void FFVoice_setAutoSendStatus(bool bAutoSend);

	[PreserveSig]
	[Token(Token = "0x6017821")]
	[Address(RVA = "0x320F190", Offset = "0x320F190", VA = "0x320F190")]
	private static extern int FFVoice_getVolume();

	[PreserveSig]
	[Token(Token = "0x6017822")]
	[Address(RVA = "0x320F288", Offset = "0x320F288", VA = "0x320F288")]
	private static extern void FFVoice_setVolume(uint uiVolume);

	[PreserveSig]
	[Token(Token = "0x6017823")]
	[Address(RVA = "0x320F390", Offset = "0x320F390", VA = "0x320F390")]
	private static extern int FFVoice_getMicVolume();

	[PreserveSig]
	[Token(Token = "0x6017824")]
	[Address(RVA = "0x320F490", Offset = "0x320F490", VA = "0x320F490")]
	private static extern void FFVoice_setMicVolume(uint uiVolume);

	[PreserveSig]
	[Token(Token = "0x6017825")]
	[Address(RVA = "0x320F5A0", Offset = "0x320F5A0", VA = "0x320F5A0")]
	private static extern void FFVoice_setUserVolume(string strUserID, uint uiVolume);

	[PreserveSig]
	[Token(Token = "0x6017826")]
	[Address(RVA = "0x320F6D8", Offset = "0x320F6D8", VA = "0x320F6D8")]
	private static extern bool FFVoice_getUseMobileNetworkEnabled();

	[PreserveSig]
	[Token(Token = "0x6017827")]
	[Address(RVA = "0x320F7C0", Offset = "0x320F7C0", VA = "0x320F7C0")]
	private static extern void FFVoice_setUseMobileNetworkEnabled(bool bEnabled);

	[PreserveSig]
	[Token(Token = "0x6017828")]
	[Address(RVA = "0x320F8A8", Offset = "0x320F8A8", VA = "0x320F8A8")]
	private static extern int FFVoice_joinChannelSingleMode(string strUserID, string strChannelID, int userRole, bool bCheckRoomExist);

	[PreserveSig]
	[Token(Token = "0x6017829")]
	[Address(RVA = "0x320F9E0", Offset = "0x320F9E0", VA = "0x320F9E0")]
	private static extern int FFVoice_joinChannelMultiMode(string strUserID, string strChannelID, int userRole, bool bCheckRoomExist);

	[PreserveSig]
	[Token(Token = "0x601782A")]
	[Address(RVA = "0x320FB18", Offset = "0x320FB18", VA = "0x320FB18")]
	private static extern int FFVoice_speakToChannel(string strChannelID);

	[PreserveSig]
	[Token(Token = "0x601782B")]
	[Address(RVA = "0x320FC50", Offset = "0x320FC50", VA = "0x320FC50")]
	private static extern int FFVoice_leaveChannelMultiMode(string strChannelID);

	[PreserveSig]
	[Token(Token = "0x601782C")]
	[Address(RVA = "0x320FD58", Offset = "0x320FD58", VA = "0x320FD58")]
	private static extern int FFVoice_leaveChannelAll();

	[PreserveSig]
	[Token(Token = "0x601782D")]
	[Address(RVA = "0x320FE60", Offset = "0x320FE60", VA = "0x320FE60")]
	private static extern int FFVoice_setPcmCallbackEnable(UnityPcmCallbackDelegate unityPcmCallback, int flag);

	[PreserveSig]
	[Token(Token = "0x601782E")]
	[Address(RVA = "0x320FF58", Offset = "0x320FF58", VA = "0x320FF58")]
	private static extern int FFVoice_setOtherMicMute(string userID, bool mute);

	[PreserveSig]
	[Token(Token = "0x601782F")]
	[Address(RVA = "0x3210098", Offset = "0x3210098", VA = "0x3210098")]
	private static extern int FFVoice_setOtherSpeakerMute(string userID, bool mute);

	[PreserveSig]
	[Token(Token = "0x6017830")]
	[Address(RVA = "0x32101A0", Offset = "0x32101A0", VA = "0x32101A0")]
	private static extern int FFVoice_setListenOtherVoice(string userID, bool isOn);

	[PreserveSig]
	[Token(Token = "0x6017831")]
	[Address(RVA = "0x32102A8", Offset = "0x32102A8", VA = "0x32102A8")]
	private static extern void FFVoice_setServerRegion(int regionId, string strExtRegionId, bool bAppend);

	[PreserveSig]
	[Token(Token = "0x6017832")]
	[Address(RVA = "0x32103E8", Offset = "0x32103E8", VA = "0x32103E8")]
	private static extern int FFVoice_playBackgroundMusic(string pFilePath, bool bRepeat);

	[PreserveSig]
	[Token(Token = "0x6017833")]
	[Address(RVA = "0x32104F0", Offset = "0x32104F0", VA = "0x32104F0")]
	private static extern int FFVoice_pauseBackgroundMusic();

	[PreserveSig]
	[Token(Token = "0x6017834")]
	[Address(RVA = "0x32105C8", Offset = "0x32105C8", VA = "0x32105C8")]
	private static extern int FFVoice_resumeBackgroundMusic();

	[PreserveSig]
	[Token(Token = "0x6017835")]
	[Address(RVA = "0x32106A0", Offset = "0x32106A0", VA = "0x32106A0")]
	private static extern int FFVoice_stopBackgroundMusic();

	[PreserveSig]
	[Token(Token = "0x6017836")]
	[Address(RVA = "0x3210778", Offset = "0x3210778", VA = "0x3210778")]
	private static extern int FFVoice_setBackgroundMusicVolume(int volume);

	[PreserveSig]
	[Token(Token = "0x6017837")]
	[Address(RVA = "0x3210860", Offset = "0x3210860", VA = "0x3210860")]
	private static extern int FFVoice_getBackgroundMusicVolume();

	[PreserveSig]
	[Token(Token = "0x6017838")]
	[Address(RVA = "0x3210940", Offset = "0x3210940", VA = "0x3210940")]
	private static extern int FFVoice_setHeadsetMonitorOn(bool micEnabled, bool bgmEnabled);

	[PreserveSig]
	[Token(Token = "0x6017839")]
	[Address(RVA = "0x3210A28", Offset = "0x3210A28", VA = "0x3210A28")]
	private static extern int FFVoice_setReverbEnabled(bool enabled);

	[PreserveSig]
	[Token(Token = "0x601783A")]
	[Address(RVA = "0x3210B40", Offset = "0x3210B40", VA = "0x3210B40")]
	private static extern int FFVoice_setVadCallbackEnabled(bool enabled);

	[PreserveSig]
	[Token(Token = "0x601783B")]
	[Address(RVA = "0x3210C20", Offset = "0x3210C20", VA = "0x3210C20")]
	private static extern int FFVoice_setSpeakerRecordOn(bool enabled);

	[PreserveSig]
	[Token(Token = "0x601783C")]
	[Address(RVA = "0x3210D00", Offset = "0x3210D00", VA = "0x3210D00")]
	private static extern bool FFVoice_isSpeakerRecording();

	[PreserveSig]
	[Token(Token = "0x601783D")]
	[Address(RVA = "0x3210DE0", Offset = "0x3210DE0", VA = "0x3210DE0")]
	private static extern bool FFVoice_isInAnyChannel();

	[PreserveSig]
	[Token(Token = "0x601783E")]
	[Address(RVA = "0x3210EF0", Offset = "0x3210EF0", VA = "0x3210EF0")]
	private static extern bool FFVoice_isInited();

	[PreserveSig]
	[Token(Token = "0x601783F")]
	[Address(RVA = "0x3210FF0", Offset = "0x3210FF0", VA = "0x3210FF0")]
	private static extern int FFVoice_cleanSpeakerRecordCache();

	[PreserveSig]
	[Token(Token = "0x6017840")]
	[Address(RVA = "0x32110C8", Offset = "0x32110C8", VA = "0x32110C8")]
	private static extern int FFVoice_setMicLevelCallback(int maxLevel);

	[PreserveSig]
	[Token(Token = "0x6017841")]
	[Address(RVA = "0x32111A8", Offset = "0x32111A8", VA = "0x32111A8")]
	private static extern int FFVoice_setFarendVoiceLevelCallback(int maxLevel, int maxMixedMicLevel);

	[PreserveSig]
	[Token(Token = "0x6017842")]
	[Address(RVA = "0x3211298", Offset = "0x3211298", VA = "0x3211298")]
	private static extern int FFVoice_pauseChannel();

	[PreserveSig]
	[Token(Token = "0x6017843")]
	[Address(RVA = "0x3211398", Offset = "0x3211398", VA = "0x3211398")]
	private static extern int FFVoice_resumeChannel();

	[PreserveSig]
	[Token(Token = "0x6017844")]
	[Address(RVA = "0x3211498", Offset = "0x3211498", VA = "0x3211498")]
	private static extern float FFVoice_getSoundtouchPitchSemiTones();

	[PreserveSig]
	[Token(Token = "0x6017845")]
	[Address(RVA = "0x3211578", Offset = "0x3211578", VA = "0x3211578")]
	private static extern int FFVoice_setSoundtouchPitchSemiTones(float fPitchSemiTones);

	[PreserveSig]
	[Token(Token = "0x6017846")]
	[Address(RVA = "0x3211660", Offset = "0x3211660", VA = "0x3211660")]
	private static extern void FFVoice_setRecordingTimeMs(uint timeMs);

	[PreserveSig]
	[Token(Token = "0x6017847")]
	[Address(RVA = "0x3211740", Offset = "0x3211740", VA = "0x3211740")]
	private static extern void FFVoice_setPlayingTimeMs(uint timeMs);

	[PreserveSig]
	[Token(Token = "0x6017848")]
	[Address(RVA = "0x3211858", Offset = "0x3211858", VA = "0x3211858")]
	private static extern int FFVoice_getSDKVersion();

	[PreserveSig]
	[Token(Token = "0x6017849")]
	[Address(RVA = "0x3211958", Offset = "0x3211958", VA = "0x3211958")]
	private static extern int FFVoice_requestRestApi(string strCommand, string strQueryBody, ref int requestID);

	[PreserveSig]
	[Token(Token = "0x601784A")]
	[Address(RVA = "0x3211AB0", Offset = "0x3211AB0", VA = "0x3211AB0")]
	private static extern int FFVoice_getChannelUserList(string strChannelID, int maxCount, bool notifyMemChange);

	[PreserveSig]
	[Token(Token = "0x601784B")]
	[Address(RVA = "0x3211BC0", Offset = "0x3211BC0", VA = "0x3211BC0")]
	private static extern int FFVoice_setToken(string strToken);

	[PreserveSig]
	[Token(Token = "0x601784C")]
	[Address(RVA = "0x3211CF0", Offset = "0x3211CF0", VA = "0x3211CF0")]
	private static extern int FFVoice_setReleaseMicWhenMute(bool enabled);

	[PreserveSig]
	[Token(Token = "0x601784D")]
	[Address(RVA = "0x3211DD0", Offset = "0x3211DD0", VA = "0x3211DD0")]
	private static extern int FFVoice_setExitCommModeWhenHeadsetPlugin(bool enabled);

	[PreserveSig]
	[Token(Token = "0x601784E")]
	[Address(RVA = "0x3211EC0", Offset = "0x3211EC0", VA = "0x3211EC0")]
	private static extern int FFVoice_setGrabMicOption(string pChannelID, int mode, int maxAllowCount, int maxTalkTime, uint voteTime);

	[PreserveSig]
	[Token(Token = "0x601784F")]
	[Address(RVA = "0x3212020", Offset = "0x3212020", VA = "0x3212020")]
	private static extern int FFVoice_startGrabMicAction(string pChannelID, string pContent);

	[PreserveSig]
	[Token(Token = "0x6017850")]
	[Address(RVA = "0x3212140", Offset = "0x3212140", VA = "0x3212140")]
	private static extern int FFVoice_stopGrabMicAction(string pChannelID, string pContent);

	[PreserveSig]
	[Token(Token = "0x6017851")]
	[Address(RVA = "0x3212298", Offset = "0x3212298", VA = "0x3212298")]
	private static extern int FFVoice_requestGrabMic(string pChannelID, int score, bool isAutoOpenMic, string pContent);

	[PreserveSig]
	[Token(Token = "0x6017852")]
	[Address(RVA = "0x32123F8", Offset = "0x32123F8", VA = "0x32123F8")]
	private static extern int FFVoice_releaseGrabMic(string pChannelID);

	[PreserveSig]
	[Token(Token = "0x6017853")]
	[Address(RVA = "0x3212530", Offset = "0x3212530", VA = "0x3212530")]
	private static extern int FFVoice_setInviteMicOption(string pChannelID, int waitTimeout, int maxTalkTime);

	[PreserveSig]
	[Token(Token = "0x6017854")]
	[Address(RVA = "0x3212640", Offset = "0x3212640", VA = "0x3212640")]
	private static extern int FFVoice_requestInviteMic(string pChannelID, string pUserID, string pContent);

	[PreserveSig]
	[Token(Token = "0x6017855")]
	[Address(RVA = "0x32127B8", Offset = "0x32127B8", VA = "0x32127B8")]
	private static extern int FFVoice_responseInviteMic(string pUserID, bool isAccept, string pContent);

	[PreserveSig]
	[Token(Token = "0x6017856")]
	[Address(RVA = "0x3212918", Offset = "0x3212918", VA = "0x3212918")]
	private static extern int FFVoice_stopInviteMic();

	[PreserveSig]
	[Token(Token = "0x6017857")]
	[Address(RVA = "0x3212A18", Offset = "0x3212A18", VA = "0x3212A18")]
	private static extern int FFVoice_sendMessage(string pChannelID, string pContent, ref int requestID);

	[PreserveSig]
	[Token(Token = "0x6017858")]
	[Address(RVA = "0x3212B68", Offset = "0x3212B68", VA = "0x3212B68")]
	private static extern int FFVoice_setWhiteUserList(string pChannelID, string pWhiteUserList);

	[PreserveSig]
	[Token(Token = "0x6017859")]
	[Address(RVA = "0x3212CC0", Offset = "0x3212CC0", VA = "0x3212CC0")]
	private static extern int FFVoice_setUserRole(int userRole);

	[PreserveSig]
	[Token(Token = "0x601785A")]
	[Address(RVA = "0x3212DD0", Offset = "0x3212DD0", VA = "0x3212DD0")]
	private static extern int FFVoice_getUserRole();

	[PreserveSig]
	[Token(Token = "0x601785B")]
	[Address(RVA = "0x3212ED0", Offset = "0x3212ED0", VA = "0x3212ED0")]
	private static extern int FFVoice_kickOtherFromChannel(string pUserID, string pChannelID, int lastTime);

	[PreserveSig]
	[Token(Token = "0x601785C")]
	[Address(RVA = "0x3213000", Offset = "0x3213000", VA = "0x3213000")]
	private static extern bool FFVoice_releaseMicSync();

	[PreserveSig]
	[Token(Token = "0x601785D")]
	[Address(RVA = "0x3213110", Offset = "0x3213110", VA = "0x3213110")]
	private static extern bool FFVoice_resumeMicSync();

	[PreserveSig]
	[Token(Token = "0x601785E")]
	[Address(RVA = "0x3213218", Offset = "0x3213218", VA = "0x3213218")]
	private static extern int FFVoice_setMagicVoiceEnable(bool enabled);

	[PreserveSig]
	[Token(Token = "0x601785F")]
	[Address(RVA = "0x32132F8", Offset = "0x32132F8", VA = "0x32132F8")]
	private static extern int FFVoice_setReportInfo(int nTimeSec, string language);

	[PreserveSig]
	[Token(Token = "0x6017860")]
	[Address(RVA = "0x3213438", Offset = "0x3213438", VA = "0x3213438")]
	private static extern int FFVoice_reportUserAudio(string reportUserID, string customData);

	[Token(Token = "0x6017861")]
	[Address(RVA = "0x3213588", Offset = "0x3213588", VA = "0x3213588")]
	private void ParseJsonCallbackMessage(string strMessage)
	{
	}

	[Token(Token = "0x6017862")]
	[Address(RVA = "0x320E2D8", Offset = "0x320E2D8", VA = "0x320E2D8")]
	private static void UnityPcmCallBackFunc(IntPtr param)
	{
	}

	[Token(Token = "0x6017863")]
	[Address(RVA = "0x3214640", Offset = "0x3214640", VA = "0x3214640")]
	public static FFVoiceAPI GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6017864")]
	[Address(RVA = "0x3214768", Offset = "0x3214768", VA = "0x3214768")]
	private void InitAndroidJava()
	{
	}

	[Token(Token = "0x6017865")]
	[Address(RVA = "0x3214B90", Offset = "0x3214B90", VA = "0x3214B90")]
	public void SetAndroidLibPath(string libPath)
	{
	}

	[Token(Token = "0x6017866")]
	[Address(RVA = "0x3214B98", Offset = "0x3214B98", VA = "0x3214B98")]
	public void SetCallback(string strObjName)
	{
	}

	[Token(Token = "0x6017867")]
	[Address(RVA = "0x3214BA0", Offset = "0x3214BA0", VA = "0x3214BA0")]
	public FFVoiceErrorCode Init(string strAppKey, string strAPPSecret, FFVoice_RTC_SERVER_REGION serverRegionId, string strExtServerRegionName, bool withInternalPermissionRequest = false)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017868")]
	[Address(RVA = "0x3214D30", Offset = "0x3214D30", VA = "0x3214D30")]
	public bool IsInited()
	{
		return default(bool);
	}

	[Token(Token = "0x6017869")]
	[Address(RVA = "0x3214DC0", Offset = "0x3214DC0", VA = "0x3214DC0")]
	public bool IsInAnyChannel()
	{
		return default(bool);
	}

	[Token(Token = "0x601786A")]
	[Address(RVA = "0x3214E50", Offset = "0x3214E50", VA = "0x3214E50")]
	public FFVoiceErrorCode setConfig(string sdkValidDomain, string QoSReportDomain, string APIDomain, string backupSDKValidIP, bool withInternalPermissionRequest = false)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601786B")]
	[Address(RVA = "0x3214F20", Offset = "0x3214F20", VA = "0x3214F20")]
	public FFVoiceErrorCode UnInit()
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601786C")]
	[Address(RVA = "0x3214FB4", Offset = "0x3214FB4", VA = "0x3214FB4")]
	public void SetServerRegion(FFVoice_RTC_SERVER_REGION regionId, string strExtRegionName)
	{
	}

	[Token(Token = "0x601786D")]
	[Address(RVA = "0x3215058", Offset = "0x3215058", VA = "0x3215058")]
	public void SetServerRegion(string[] regionNames)
	{
	}

	[Token(Token = "0x601786E")]
	[Address(RVA = "0x3215194", Offset = "0x3215194", VA = "0x3215194")]
	public FFVoiceErrorCode SetOutputToSpeaker(bool bOutputToSpeaker)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601786F")]
	[Address(RVA = "0x3215230", Offset = "0x3215230", VA = "0x3215230")]
	public void SetSpeakerMute(bool bMute)
	{
	}

	[Token(Token = "0x6017870")]
	[Address(RVA = "0x32152C0", Offset = "0x32152C0", VA = "0x32152C0")]
	public bool GetSpeakerMute()
	{
		return default(bool);
	}

	[Token(Token = "0x6017871")]
	[Address(RVA = "0x3215350", Offset = "0x3215350", VA = "0x3215350")]
	public void SetMicrophoneMute(bool mute)
	{
	}

	[Token(Token = "0x6017872")]
	[Address(RVA = "0x32153E0", Offset = "0x32153E0", VA = "0x32153E0")]
	public bool GetMicrophoneMute()
	{
		return default(bool);
	}

	[Token(Token = "0x6017873")]
	[Address(RVA = "0x3215470", Offset = "0x3215470", VA = "0x3215470")]
	public void SetAutoSendStatus(bool bAutoSend)
	{
	}

	[Token(Token = "0x6017874")]
	[Address(RVA = "0x3215500", Offset = "0x3215500", VA = "0x3215500")]
	public void SetVolume(uint uiVolume)
	{
	}

	[Token(Token = "0x6017875")]
	[Address(RVA = "0x3215590", Offset = "0x3215590", VA = "0x3215590")]
	public int GetVolume()
	{
		return default(int);
	}

	[Token(Token = "0x6017876")]
	[Address(RVA = "0x3215620", Offset = "0x3215620", VA = "0x3215620")]
	public void SetMicVolume(uint uiVolume)
	{
	}

	[Token(Token = "0x6017877")]
	[Address(RVA = "0x32156B0", Offset = "0x32156B0", VA = "0x32156B0")]
	public void SetUserVolume(string strUserID, uint uiVolume)
	{
	}

	[Token(Token = "0x6017878")]
	[Address(RVA = "0x3215748", Offset = "0x3215748", VA = "0x3215748")]
	public int GetMicVolume()
	{
		return default(int);
	}

	[Token(Token = "0x6017879")]
	[Address(RVA = "0x32157D8", Offset = "0x32157D8", VA = "0x32157D8")]
	public void SetUseMobileNetworkEnabled(bool bEnabled)
	{
	}

	[Token(Token = "0x601787A")]
	[Address(RVA = "0x3215868", Offset = "0x3215868", VA = "0x3215868")]
	public bool GetUseMobileNetworkEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x601787B")]
	[Address(RVA = "0x32158F8", Offset = "0x32158F8", VA = "0x32158F8")]
	public FFVoiceErrorCode JoinChannelSingleMode(string strUserID, string strChannelID, FFVoiceUserRole userRole, bool bCheckRoomExist = false)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601787C")]
	[Address(RVA = "0x32159B8", Offset = "0x32159B8", VA = "0x32159B8")]
	public FFVoiceErrorCode JoinChannelMultiMode(string strUserID, string strChannelID, FFVoiceUserRole userRole, bool bCheckRoomExist = false)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601787D")]
	[Address(RVA = "0x3215A78", Offset = "0x3215A78", VA = "0x3215A78")]
	public FFVoiceErrorCode JoinChannelMultiMode(string strUserID, string strChannelID, bool bCheckRoomExist = false)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601787E")]
	[Address(RVA = "0x3215B34", Offset = "0x3215B34", VA = "0x3215B34")]
	public FFVoiceErrorCode SpeakToChannel(string strChannelID)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601787F")]
	[Address(RVA = "0x3215BD0", Offset = "0x3215BD0", VA = "0x3215BD0")]
	public FFVoiceErrorCode LeaveChannelMultiMode(string strChannelID)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017880")]
	[Address(RVA = "0x3215C6C", Offset = "0x3215C6C", VA = "0x3215C6C")]
	public FFVoiceErrorCode LeaveChannelAll()
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017881")]
	[Address(RVA = "0x3215D00", Offset = "0x3215D00", VA = "0x3215D00")]
	public FFVoiceErrorCode SetPcmCallbackEnable(Action<FFVoicePcmCallbackData> callback, int flag)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017882")]
	[Address(RVA = "0x3215E90", Offset = "0x3215E90", VA = "0x3215E90")]
	public FFVoiceErrorCode SetPcmCallback(Action<FFVoicePcmCallbackData> callback, bool bOutputToSpeaker = true)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017883")]
	[Address(RVA = "0x3216008", Offset = "0x3216008", VA = "0x3216008")]
	public FFVoiceErrorCode SetOtherMicMute(string userID, bool mute)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017884")]
	[Address(RVA = "0x32160AC", Offset = "0x32160AC", VA = "0x32160AC")]
	public FFVoiceErrorCode SetOtherSpeakerMute(string userID, bool mute)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017885")]
	[Address(RVA = "0x3216150", Offset = "0x3216150", VA = "0x3216150")]
	public FFVoiceErrorCode SetListenOtherVoice(string userID, bool isOn)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017886")]
	[Address(RVA = "0x32161F4", Offset = "0x32161F4", VA = "0x32161F4")]
	public FFVoiceErrorCode PlayBackgroundMusic(string strFilePath, bool bRepeat)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017887")]
	[Address(RVA = "0x3216298", Offset = "0x3216298", VA = "0x3216298")]
	public FFVoiceErrorCode PauseBackgroundMusic()
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017888")]
	[Address(RVA = "0x321632C", Offset = "0x321632C", VA = "0x321632C")]
	public FFVoiceErrorCode ResumeBackgroundMusic()
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017889")]
	[Address(RVA = "0x32163C0", Offset = "0x32163C0", VA = "0x32163C0")]
	public FFVoiceErrorCode StopBackgroundMusic()
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601788A")]
	[Address(RVA = "0x3216454", Offset = "0x3216454", VA = "0x3216454")]
	public FFVoiceErrorCode SetBackgroundMusicVolume(int volume)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601788B")]
	[Address(RVA = "0x32164F0", Offset = "0x32164F0", VA = "0x32164F0")]
	public int GetBackgroundMusicVolume()
	{
		return default(int);
	}

	[Token(Token = "0x601788C")]
	[Address(RVA = "0x3216580", Offset = "0x3216580", VA = "0x3216580")]
	public FFVoiceErrorCode SetHeadsetMonitorOn(bool micEnabled, bool bgmEnabled = true)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601788D")]
	[Address(RVA = "0x3216624", Offset = "0x3216624", VA = "0x3216624")]
	public FFVoiceErrorCode SetReverbEnabled(bool enabled)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601788E")]
	[Address(RVA = "0x32166C0", Offset = "0x32166C0", VA = "0x32166C0")]
	public FFVoiceErrorCode SetVadCallbackEnabled(bool enabled)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601788F")]
	[Address(RVA = "0x321675C", Offset = "0x321675C", VA = "0x321675C")]
	public FFVoiceErrorCode SetSpeakerRecordOn(bool enabled)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017890")]
	[Address(RVA = "0x32167F8", Offset = "0x32167F8", VA = "0x32167F8")]
	public bool IsSpeakerRecording()
	{
		return default(bool);
	}

	[Token(Token = "0x6017891")]
	[Address(RVA = "0x3216870", Offset = "0x3216870", VA = "0x3216870")]
	public FFVoiceErrorCode CleanSpeakerRecordCache()
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017892")]
	[Address(RVA = "0x3216904", Offset = "0x3216904", VA = "0x3216904")]
	public FFVoiceErrorCode SetMicLevelCallback(int maxMicLevel)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017893")]
	[Address(RVA = "0x32169A0", Offset = "0x32169A0", VA = "0x32169A0")]
	public FFVoiceErrorCode SetFarendVoiceLevelCallback(int maxMicLevel, int maxMixedMicLevel)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017894")]
	[Address(RVA = "0x3216A44", Offset = "0x3216A44", VA = "0x3216A44")]
	public FFVoiceErrorCode PauseChannel()
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017895")]
	[Address(RVA = "0x3216AD8", Offset = "0x3216AD8", VA = "0x3216AD8")]
	public FFVoiceErrorCode ResumeChannel()
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017896")]
	[Address(RVA = "0x3216B6C", Offset = "0x3216B6C", VA = "0x3216B6C")]
	public float GetSoundtouchPitchSemiTones()
	{
		return default(float);
	}

	[Token(Token = "0x6017897")]
	[Address(RVA = "0x3216BFC", Offset = "0x3216BFC", VA = "0x3216BFC")]
	public FFVoiceErrorCode SetSoundtouchPitchSemiTones(float fPitchSemiTones)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x6017898")]
	[Address(RVA = "0x3216C98", Offset = "0x3216C98", VA = "0x3216C98")]
	public void SetRecordingTimeMs(uint timeMs)
	{
	}

	[Token(Token = "0x6017899")]
	[Address(RVA = "0x3216D28", Offset = "0x3216D28", VA = "0x3216D28")]
	public void SetPlayingTimeMs(uint timeMs)
	{
	}

	[Token(Token = "0x601789A")]
	[Address(RVA = "0x3216DB8", Offset = "0x3216DB8", VA = "0x3216DB8")]
	public int GetSDKVersion()
	{
		return default(int);
	}

	[Token(Token = "0x601789B")]
	[Address(RVA = "0x3216E48", Offset = "0x3216E48", VA = "0x3216E48")]
	public FFVoiceErrorCode RequestRestApi(string command, string queryBody, ref int requestID)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601789C")]
	[Address(RVA = "0x3216EF4", Offset = "0x3216EF4", VA = "0x3216EF4")]
	public FFVoiceErrorCode GetChannelUserList(string channelID, int maxCount, bool notifyMemChange)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601789D")]
	[Address(RVA = "0x3216FA0", Offset = "0x3216FA0", VA = "0x3216FA0")]
	public void SetToken(string strToken)
	{
	}

	[Token(Token = "0x601789E")]
	[Address(RVA = "0x3217030", Offset = "0x3217030", VA = "0x3217030")]
	public FFVoiceErrorCode SetReleaseMicWhenMute(bool enabled)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x601789F")]
	[Address(RVA = "0x32170CC", Offset = "0x32170CC", VA = "0x32170CC")]
	public FFVoiceErrorCode SetExitCommModeWhenHeadsetPlugin(bool enabled)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A0")]
	[Address(RVA = "0x3217168", Offset = "0x3217168", VA = "0x3217168")]
	public FFVoiceErrorCode SetGrabMicOption(string pChannelID, int mode, int maxAllowCount, int maxTalkTime, uint voteTime)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A1")]
	[Address(RVA = "0x3217230", Offset = "0x3217230", VA = "0x3217230")]
	public FFVoiceErrorCode StartGrabMicAction(string pChannelID, string pContent)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A2")]
	[Address(RVA = "0x32172D4", Offset = "0x32172D4", VA = "0x32172D4")]
	public FFVoiceErrorCode StopGrabMicAction(string pChannelID, string pContent)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A3")]
	[Address(RVA = "0x3217378", Offset = "0x3217378", VA = "0x3217378")]
	public FFVoiceErrorCode requestGrabMic(string pChannelID, int score, bool isAutoOpenMic, string pContent)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A4")]
	[Address(RVA = "0x3217438", Offset = "0x3217438", VA = "0x3217438")]
	public FFVoiceErrorCode releaseGrabMic(string pChannelID)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A5")]
	[Address(RVA = "0x32174D4", Offset = "0x32174D4", VA = "0x32174D4")]
	public FFVoiceErrorCode setInviteMicOption(string pChannelID, int waitTimeout, int maxTalkTime)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A6")]
	[Address(RVA = "0x3217580", Offset = "0x3217580", VA = "0x3217580")]
	public FFVoiceErrorCode requestInviteMic(string pChannelID, string pUserID, string pContent)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A7")]
	[Address(RVA = "0x321762C", Offset = "0x321762C", VA = "0x321762C")]
	public FFVoiceErrorCode responseInviteMic(string pUserID, bool isAccept, string pContent)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A8")]
	[Address(RVA = "0x32176D8", Offset = "0x32176D8", VA = "0x32176D8")]
	public FFVoiceErrorCode stopInviteMic()
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178A9")]
	[Address(RVA = "0x321776C", Offset = "0x321776C", VA = "0x321776C")]
	public FFVoiceErrorCode SendMessage(string channelID, string content, ref int requestID)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178AA")]
	[Address(RVA = "0x3217818", Offset = "0x3217818", VA = "0x3217818")]
	public FFVoiceErrorCode SetWhiteUserList(string channelID, string whiteUserList)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178AB")]
	[Address(RVA = "0x32178BC", Offset = "0x32178BC", VA = "0x32178BC")]
	public FFVoiceErrorCode SetUserRole(FFVoiceUserRole userRole)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178AC")]
	[Address(RVA = "0x3217958", Offset = "0x3217958", VA = "0x3217958")]
	public FFVoiceUserRole GetUserRole()
	{
		return default(FFVoiceUserRole);
	}

	[Token(Token = "0x60178AD")]
	[Address(RVA = "0x32179D0", Offset = "0x32179D0", VA = "0x32179D0")]
	public FFVoiceErrorCode KickOtherFromChannel(string userID, string channelID, int lastTime)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178AE")]
	[Address(RVA = "0x3217A7C", Offset = "0x3217A7C", VA = "0x3217A7C")]
	public bool ReleaseMicSync()
	{
		return default(bool);
	}

	[Token(Token = "0x60178AF")]
	[Address(RVA = "0x3217B0C", Offset = "0x3217B0C", VA = "0x3217B0C")]
	public bool ResumeMicSync()
	{
		return default(bool);
	}

	[Token(Token = "0x60178B0")]
	[Address(RVA = "0x3217B9C", Offset = "0x3217B9C", VA = "0x3217B9C")]
	public FFVoiceErrorCode SetMagicVoiceEnable(bool enabled)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178B1")]
	[Address(RVA = "0x3217C38", Offset = "0x3217C38", VA = "0x3217C38")]
	public FFVoiceErrorCode SetReportInfo(int nTimeSec, string language)
	{
		return default(FFVoiceErrorCode);
	}

	[Token(Token = "0x60178B2")]
	[Address(RVA = "0x3217CDC", Offset = "0x3217CDC", VA = "0x3217CDC")]
	public FFVoiceErrorCode ReportUserAudio(string reportUserID, string customData)
	{
		return default(FFVoiceErrorCode);
	}
}
