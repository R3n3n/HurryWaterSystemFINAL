-- Optional: the Setup screen applies this itself the first time a product is saved,
-- so you only need to run it by hand if the app reports it couldn't.
--
-- tblproducts was created with ENUM columns, which only allow the original 8 products.
-- This turns them into VARCHAR(30) so new products (e.g. a 1L bottle, "Purified" water)
-- can be added. Existing rows and values are kept exactly as they are.

ALTER TABLE `tblproducts`
  MODIFY `category` VARCHAR(30) NOT NULL,
  MODIFY `containerType` VARCHAR(30) NOT NULL,
  MODIFY `waterType` VARCHAR(30) NOT NULL;
