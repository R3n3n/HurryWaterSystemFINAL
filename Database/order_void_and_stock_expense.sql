-- Optional: the app applies all of this by itself the first time the screens that need it open
-- (Stock In). Run it by hand in phpMyAdmin
-- only if the app reports it couldn't.
--
-- Hole 14: remember which stock-in created a Supplies expense.

ALTER TABLE `tblexpenses`
  ADD COLUMN `stockTransactionId` INT NULL;

-- OPTIONAL, run only if you want PAST stock-ins to show up as expenses too.
-- Stock-ins saved before this change were never recorded as expenses. Do NOT run this if you
-- already typed those purchases into the Expenses screen by hand (for example the 900.00
-- Supplies entry), or they will be counted twice. Remove the rows you already entered first.
--
-- INSERT INTO `tblexpenses` (`expenseDate`, `category`, `amount`, `description`, `recordedBy`, `stockTransactionId`)
-- SELECT t.`transactionDate`, 'Supplies', t.`totalCost`,
--        CONCAT('Stock-in: ', i.`itemName`, ' x ', t.`quantity`), t.`recordedBy`, t.`transactionId`
-- FROM `tblstocktransactions` t
-- JOIN `tblinventoryitems` i ON i.`itemId` = t.`itemId`
-- WHERE t.`transactionType` = 'Stock-in' AND t.`totalCost` > 0
--   AND t.`transactionId` NOT IN (SELECT `stockTransactionId` FROM `tblexpenses` WHERE `stockTransactionId` IS NOT NULL);
