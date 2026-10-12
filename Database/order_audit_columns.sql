-- Optional: the Sales / Delivery screen applies this itself the first time it opens.
-- Adds "who last handled this order" to the orders table.

ALTER TABLE `tblsalesorders`
  ADD COLUMN `handledBy` INT NULL,
  ADD COLUMN `handledAt` DATETIME NULL;
