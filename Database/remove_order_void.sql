-- OPTIONAL one-time cleanup after removing the "void order" feature.
-- Run in phpMyAdmin on your existing database. Back it up first.
--
-- 1) Orders that were voided in the past still exist with pickupStatus = 'Voided'.
--    The app no longer knows that status, so remove them (items first, then the orders).
DELETE d FROM `tblsalesorderdetails` d
JOIN `tblsalesorders` o ON o.`orderId` = d.`orderId`
WHERE o.`pickupStatus` = 'Voided';

DELETE FROM `tblsalesorders` WHERE `pickupStatus` = 'Voided';

-- 2) Take 'Voided' out of the allowed statuses.
ALTER TABLE `tblsalesorders`
  MODIFY `pickupStatus` ENUM('Pending','Picked-up','Delivered','Missed') NOT NULL DEFAULT 'Pending';

-- 3) The order log table is no longer used.
DROP TABLE IF EXISTS `tblorderlog`;
