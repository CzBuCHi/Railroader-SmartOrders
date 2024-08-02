//namespace SmartOrders.HarmonyPatches;

//using Game.Messages;
//using HarmonyLib;
//using JetBrains.Annotations;
//using Model;
//using Model.AI;
//using UI.EngineControls;


//[PublicAPI]
//[HarmonyPatch]
//public static class AutoEngineerOrdersHelperPatches {

//    [HarmonyPrefix]
//    [HarmonyPatch(typeof(AutoEngineerOrdersHelper), "SendAutoEngineerCommand")]
//    public static void SendAutoEngineerCommand(ref AutoEngineerMode mode, bool forward, ref int maxSpeedMph, float? distance, Car ____locomotive) {
//        if (!SmartOrdersPlugin.Shared!.IsEnabled) {
//            return;
//        }

//        if (mode == AutoEngineerMode.Road && distance != null) {
//            var persistence = new AutoEngineerPersistence(____locomotive.KeyValueObject);
//            mode = AutoEngineerMode.Yard;
//            maxSpeedMph = persistence.Orders.MaxSpeedMph;
//        }
//    }

//}
